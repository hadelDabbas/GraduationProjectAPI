using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : Controller
    {
        private readonly IGame db;
        public GameController(IGame _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetGames()
        {
            IQueryable<Game> data = db.GetGames;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetGame(id);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
               // return NotFound();
                return Ok(new List<object>());
            }
        }
        [HttpPost]
        public IActionResult AddGame([FromBody] Game game)
        {
            if (game == null)
            {
               // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(game);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Game game)
        {
            if (game == null || game.Id == 0)
            {
               // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(game);
                return Ok();
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return Ok();
        }
    }
}
