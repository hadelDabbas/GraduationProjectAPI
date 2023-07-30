using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProjectAPI.Controllers
{
    [Route("api/[controller]/[action]")]
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
               // return NotFound();
                return Ok(new List<object>());
            }
        }
        [HttpPost]
        public IActionResult AddLibrary([FromBody] Library library)
        {
            if (library == null)
            {
               // return BadRequest();
                return Ok(new List<object>());
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
               // return BadRequest();
               return Ok(new List<object>());
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
        [HttpGet]
        [ActionName("GetLibraryBook")]
        public IActionResult GetLibraryBook([FromQuery] int IdLibrary)
        {
            if(IdLibrary != 0)
            {
                var data = db.GetBookLibrary(IdLibrary);
                if(data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return Ok(new List<object>());
                }
            }
            else
            {
                //return BadRequest();
                return Ok(new List<object>());
            }
        }
        [HttpGet]
        [ActionName("GetBookWriters")]
        public IActionResult GetBookWriters([FromQuery] int IdLibrary,[FromQuery] int IdWriter)
        {
            if(IdLibrary != 0 && IdWriter !=0)
            {
                var data = db.GetBookWriters(IdLibrary, IdWriter);
                if(data != null)
                {
                    return Ok(data);
                }
                else
                {
                  //  return NotFound();
                    return Ok(new List<object>());
                }
            }
            else
            {
              //  return BadRequest();
                return Ok(new List<object>());
            }
        }
        [HttpGet]
        [ActionName("GetBookType")]
        public IActionResult GetBookType([FromQuery] int IdLibrary,[FromQuery] int IdType)
        {
            if(IdLibrary != 0 && IdType !=0)
            {
                var data = db.GetBookType(IdLibrary, IdType);
                if(data != null)
                {
                    return Ok(data);
                }
                else
                {
                   // return NotFound();
                    return Ok(new List<object>());
                }
            }
            else
            {
              //  return BadRequest();
                return Ok(new List<object>());
            }
        }
        [HttpGet]
        [ActionName("GetLibraryBookType")]
        public IActionResult GetLibraryBookType([FromQuery] int IdLibrary)
        {
            if(IdLibrary != 0)
            {
                var data = db.GetLibraryBookType(IdLibrary);
                if(data != null)
                {
                    return Ok(data);
                }
                else
                {
                    return NotFound();
                    return Ok(new List<object>());
                }
            }
            else
            {
                //return BadRequest();
                return Ok(new List<object>());
            }
        }
    }
}
