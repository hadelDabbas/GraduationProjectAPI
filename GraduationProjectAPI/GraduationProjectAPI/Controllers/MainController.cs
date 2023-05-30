using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProjectAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : Controller
    {
        private readonly IMain db;
        public MainController(IMain _db)
        {
            db = _db;
        }
        [HttpGet]
        [ActionName("Posts")]
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
        [HttpGet]
        [ActionName("PostsContent")]
        public IActionResult PostsContent([FromQuery] int IdUser, [FromQuery] int IdContent)
        {
            if (IdUser != 0 && IdContent != 0)
            {
                var data = db.PostContent(IdUser,IdContent);
                if (data != null)
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
