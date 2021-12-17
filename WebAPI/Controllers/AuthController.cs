using System;
using System.Security.Cryptography.X509Certificates;
using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]

        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Succes)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccesToken(userToLogin.Data);
            if (result.Succes)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);

        }
        [HttpPost("register")]

        public IActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Succes)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto,password:userForRegisterDto.Password);
            var result = _authService.CreateAccesToken(registerResult.Data);
            if (result.Succes)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}