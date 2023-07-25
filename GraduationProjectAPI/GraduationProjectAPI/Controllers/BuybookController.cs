using GraduationProjectAPI.Model;
using GraduationProjectAPI.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraduationProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuybookController : Controller
    {
        private readonly IBuybook db;
        public BuybookController(IBuybook _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetBuybooks()
        {
            IQueryable<Buybook> data = db.GetBuybooks;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetBuybook(id);
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
        public IActionResult AddBuybook([FromBody] Buybook buybook)
        {
            if (buybook == null)
            {
                //  return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(buybook);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Buybook buybook)
        {
            if (buybook == null || buybook.Id == 0)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(buybook);
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
