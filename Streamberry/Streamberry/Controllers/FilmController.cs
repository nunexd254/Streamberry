using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Streamberry.Models;
using System.Collections.Generic;

namespace Streamberry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<FilmModel>> BuscarTodosFilmes()
        {
            return Ok();
        }
    }
}
