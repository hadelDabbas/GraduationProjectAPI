using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : Controller
    {
        private readonly ILibrary db;
        public LibraryController(ILibrary _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetLibraries()
        {
            IQueryable<Library> data = db.GetLibraries;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetLibrary(id);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
               // return Ok(new List<object>());
            }
        }
        [HttpPost]
        public IActionResult AddLibrary([FromBody] Library library)
        {
            if (library == null)
            {
                return BadRequest();
                //return Ok(new List<object>());
            }
            else
            {
                db.Save(library);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Library library)
        {
            if (library == null || library.Id == 0)
            {
                return BadRequest();
               // return Ok(new List<object>());
            }
            else
            {
                db.Update(library);
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
