using EjemploApiRest.Application;
using EjemploApiRest.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploApiRest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballTeamController : ControllerBase
    {
        //el controller tiene un constructor que recibe por parametro la aplicacion de footballTeam
        //agregamos la inyeccion de dependencias
        //cuando se instancie el parametro de IApplication de FootballTeam lo guardamos en un objeto local Aplication para poder usarlo una vez instanciado 
        IApplication<FootballTeam> _football;
        public FootballTeamController(IApplication<FootballTeam> football)
        {
            _football = football;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new FootballTeam
            {
                name = "San Lorenzo",
                score = 100
            });
        }
    }
}
