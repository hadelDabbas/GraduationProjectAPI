using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintController : Controller
    {
        private readonly IComplaint db;
        public ComplaintController(IComplaint _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetComplaints()
        {
            IQueryable<Complaint> data = db.GetComplaints;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetComplaint(id);
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
        public IActionResult AddComplaint([FromBody] Complaint complaint)
        {
            if (complaint == null)
            {
               // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(complaint);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Complaint complaint)
        {
            if (complaint == null || complaint.Id == 0)
            {
               // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(complaint);
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
