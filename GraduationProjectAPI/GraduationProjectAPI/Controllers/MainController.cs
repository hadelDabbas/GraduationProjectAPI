using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : Controller
    {
        private readonly IMain db;
        public MainController(IMain _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult Posts([FromQuery] int IdUser)
        {
            if(IdUser != 0)
            {
                var data = db.Posts(IdUser);
                if(data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            return BadRequest();
        }
    }
}
