using System.Collections.Generic;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
        [Route("/disciplinas")]
        public class DisciplinaController:ControllerBase
        {
            private readonly DisciplinaService _disciplinaService;

            public DisciplinaController(DisciplinaService disciplinaService)
            {
                this._disciplinaService = disciplinaService;
            }

            [Route("/topologia")]
            [HttpGet]
            //A lista materiasRealizadas precisa estar ordenada
            public IActionResult GetTopologia([FromQuery] List<int> materiasRealizadas){
                var result =this._disciplinaService.GetTopologia(materiasRealizadas);
                return Ok(result);
            }

         
    }
}