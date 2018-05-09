using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;

namespace SolisTech.FRSAdminPortal.WebApi.Controllers
{
    [Authorize]
    public class ValuesController : BaseController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //[Authorize]
        // GET api/values/5
        public string Get(int id)
        {

            var clientContext = GetDbContext();

            clientContext.Dispose();
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
