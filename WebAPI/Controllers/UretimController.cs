using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UretimController : ControllerBase
    {
        private IUretimService _uretimService;

        public UretimController(IUretimService uretimService)
        {
            _uretimService = uretimService;
        }


        [HttpGet("getall")]
        //[Authorize()]
        public IActionResult GetList()
        {
            var result = _uretimService.GetUretimForTable();
            if (result.Succes)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
