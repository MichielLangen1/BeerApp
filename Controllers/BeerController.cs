using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.Data;
using back_end.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private ApplicationDBContext _context;

        public BeerController(ApplicationDBContext context) => _context = context;

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Beer>> Get()
        {
            return _context.Beers.Include(r => r.Brand).Include(t => t.Ingredients).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Beer> Get(string id)
        {
            return _context.Beers.Include(r => r.Brand).Include(t => t.Ingredients).FirstOrDefault(r => r.ID == id);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Beer value)
        {
            _context.Beers.Add(value);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new {id = value.ID }, value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Beer value)
        {
            _context.Beers.Update(value);
            await _context.SaveChangesAsync();
            return CreatedAtAction("Get", new {id = value.ID }, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
