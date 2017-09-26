using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class DeviseController : ApiController
    {
        // GET: api/Devise
        public IQueryable<Devise> Get()
        {
            List<Devise> Devises = new List<Devise>();
            Devises.Add(new Devise(1, "Dollar", 1.08));
            Devises.Add(new Devise(2, "Franc suisse", 1.07));
            Devises.Add(new Devise(3, "Yen", 120));

            return Devises.AsQueryable();
        }

        // GET: api/Devise/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Devise
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Devise/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Devise/5
        public void Delete(int id)
        {
        }
    }
}
