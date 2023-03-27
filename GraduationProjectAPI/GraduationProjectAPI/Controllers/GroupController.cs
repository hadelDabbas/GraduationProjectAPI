using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : Controller
    {
        private readonly IGroup db;
        public GroupController(IGroup _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetGroups()
        {
            IQueryable<Group> data = db.GetGroups;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetGroup(id);
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
        public IActionResult AddGroup([FromBody] Group group)
        {
            if (group == null)
            {
                return BadRequest();
               // return Ok(new List<object>());
            }
            else
            {
                db.Save(group);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Group group)
        {
            if (group == null || group.Id == 0)
            {
                return BadRequest();
               // return Ok(new List<object>());
            }
            else
            {
                db.Update(group);
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
