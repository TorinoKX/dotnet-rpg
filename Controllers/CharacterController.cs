using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.models;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character { Name = "sam"}
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingle()
        {
            return Ok(characters[0]);
        }
    }
}