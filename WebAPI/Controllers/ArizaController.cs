using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArizaController : ControllerBase
    {
        private IArizaService _arizaService;

        public ArizaController(IArizaService arizaService)
        {
            _arizaService = arizaService;
        }

        [HttpGet("arizachart")]
        //[Authorize()]
        public IActionResult ArizaChart()
        {
            var result = _arizaService.GetArizaChart();
            if (result.Succes)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getall")]
        //[Authorize()]
        public IActionResult GetList()
        {
            var result = _arizaService.GetForTable();
            if (result.Succes)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int arizaId)
        {
            var result = _arizaService.GetById(arizaId);
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Ariza ariza)
        {
            var result = _arizaService.Add(ariza);
            if (result.Succes)
            {
                return Ok(result.Message);

            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Ariza ariza)
        {
            var result = _arizaService.Update(ariza);
            if (result.Succes)
            {
                return Ok(result.Message);

            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Ariza ariza)
        {
            var result = _arizaService.Delete(ariza);
            if (result.Succes)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

    }
}
