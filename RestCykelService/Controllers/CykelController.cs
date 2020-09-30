using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CykelLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestCykelService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CykelController : ControllerBase
    {

        //date

        private static List<Cykel> _data = new List<Cykel>()
        {
            new Cykel(1, "gul", 5000, 25),
            new Cykel(2, "blå", 5500, 22),
            new Cykel(3, "grøn", 3000, 20),
            new Cykel(4, "lilla", 3500, 19)
        };

        // GET: api/Cykel
        [HttpGet]
        public IEnumerable<Cykel> Get()
        {
            return _data;
        }

        // GET: api/Cykel/5
        [HttpGet("{id}", Name = "Get")]
        public Cykel Get(int id)
        {
            return _data.Find(i => i.Id == id);
        }

        // POST: api/Cykel
        [HttpPost]
        public void Post([FromBody] Cykel value)
        {
            _data.Add(value);
        }

        // PUT: api/Cykel/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cykel value)
        {
            Cykel Cykel = Get(id);
            if (Cykel != null)
            {
                Cykel.Id = value.Id;
                Cykel.Farve = value.Farve;
                Cykel.Pris = value.Pris;
                Cykel.Gear = value.Gear;
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Cykel cykel = Get(id);
            if (cykel != null)
            {
                _data.Remove(cykel);
            }
        }
    }
}
