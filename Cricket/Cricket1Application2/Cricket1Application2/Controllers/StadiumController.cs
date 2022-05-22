using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cricket1Application2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cricket1Application2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StadiumController : ControllerBase
    {
        private readonly CricketContext _Cricketcontext;
        public StadiumController(CricketContext a)
        {
            _Cricketcontext = a;   //dependency injection
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            var getStadium = _Cricketcontext.Stadium.ToList();
            return Ok(getStadium);
        }

        // GET: api/Stadium/5
       /* [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        } */

        // POST: api/Stadium
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Stadium/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
