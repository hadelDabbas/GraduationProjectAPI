using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : Controller
    {
        private readonly IType db;
        public TypeController(IType _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetTypes()
        {
            IQueryable<Model.Type> data = db.GetTypes;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetType(id);
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
        public IActionResult AddType([FromBody] Model.Type type)
        {
            if (type == null)
            {
                return BadRequest();
               // return Ok(new List<object>());
            }
            else
            {
                db.Save(type);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Model.Type type)
        {
            if (type == null || type.Id == 0)
            {
                return BadRequest();
               // return Ok(new List<object>());
            }
            else
            {
                db.Update(type);
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
