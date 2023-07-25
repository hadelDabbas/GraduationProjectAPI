using GraduationProjectAPI.Infrastructure;
using GraduationProjectAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBook db;
        public BookController(IBook _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetBooks()
        {
            IQueryable<Book> data = db.GetBooks;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetBook(id);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                //  return NotFound();
                return Ok(new List<object>());
            }
        }
        [HttpPost]
        public IActionResult AddBook([FromBody] Book book)
        {
            if (book == null)
            {
                //  return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(book);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Book book)
        {
            if (book == null || book.Id == 0)
            {
                //  return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(book);
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
