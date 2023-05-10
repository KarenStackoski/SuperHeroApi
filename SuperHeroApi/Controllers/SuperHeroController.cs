using Microsoft.AspNetCore.Mvc;
using SuperHeroApi.Interfaces;
using System.Net;

namespace SuperHeroApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SuperHeroController : ControllerBase //using ControllerBase: defining as controller
    {
        public readonly ISuperHero _superHero;

        public SuperHeroController(ISuperHero superHero) //constructor of _superHero
        {
            _superHero = superHero;
        }

        [HttpGet("{token}/{id}")]

        public async Task<ActionResult> GetSuperHero([FromRoute] string id, [FromRoute] string token)
        {
            var response = await _superHero.GetSuperHero(id, token);

            if (response.HttpCode == HttpStatusCode.OK)
            {
                return Ok(response.ReturnData);
            }
            else
            {
                return StatusCode((int)response.HttpCode, response.ReturnError);
            }
        }
    }
}
