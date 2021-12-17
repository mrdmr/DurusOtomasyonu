using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        private IPersonelService _personelService;

        public PersonelController(IPersonelService personelService)
        {
            _personelService = personelService;
        }
        [HttpGet("getall")]
        //[Authorize()]
        public IActionResult GetList()
        {
            var result = _personelService.GetAll();
            if (result.Succes)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int arizaId)
        {
            var result = _personelService.GetById(arizaId);
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Personel personel)
        {
            var result = _personelService.Add(personel);
            if (result.Succes)
            {
                return Ok(result.Message);

            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Personel personel)
        {
            var result = _personelService.Update(personel);
            if (result.Succes)
            {
                return Ok(result.Message);

            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Personel personel)
        {
            var result = _personelService.Delete(personel);
            if (result.Succes)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
