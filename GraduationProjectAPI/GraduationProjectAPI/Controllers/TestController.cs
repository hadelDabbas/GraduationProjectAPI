using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProjectAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : Controller
    {
        private readonly ITest db;
        public TestController(ITest _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetTests()
        {
            IQueryable<Test> data = db.GetTests;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetTest(id);
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
        public IActionResult AddTest([FromBody] Test test)
        {
            if (test == null)
            {
              //  return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(test);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Test test)
        {
            if (test == null || test.Id == 0)
            {
               // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(test);
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
        [ActionName("GetTestContent")]
        public IActionResult GetTestContent()
        {
            var data = db.GetTestContent();
            if(data != null)
            {
                return Ok(data);
            }
            else
            {
                return Ok(new List<object>());
               // return NotFound();
            }
        }
    }
}
