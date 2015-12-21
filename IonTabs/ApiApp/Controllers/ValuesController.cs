using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiApp.Controllers
{
    /// <summary>
    /// A default controller that comes with the project template.
    /// </summary>
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Get the values
        /// </summary>
        /// <returns>Values from the controller</returns>
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Get a specific value
        /// </summary>
        /// <param name="id">id of the value to get</param>
        /// <returns>The value</returns>
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Post the new value
        /// </summary>
        /// <param name="value">the new value content</param>
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Put the modify value.
        /// </summary>
        /// <param name="id">the ref id.</param>
        /// <param name="value">the updated value.</param>
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Delete the value
        /// </summary>
        /// <param name="id">the value to be deleted.</param>
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
