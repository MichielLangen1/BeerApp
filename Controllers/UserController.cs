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
    public class UserController : ControllerBase
    {
        private ApplicationDBContext _context;

        public UserController(ApplicationDBContext context) => _context = context;

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Beer>> Get()
        {

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Beer> Get(string id)
        {

        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Beer value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] User value)
        {
            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
