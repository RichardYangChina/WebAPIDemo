using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.DAO;
using Newtonsoft.Json;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    [Produces("application/json")]
    [Route("api/Home")]
    public class HomeController : Controller
    {
        // GET: api/Home
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //GET: api/Home/5
        [HttpGet("{id}", Name = "Get")]
        public string About(int id)
        {
            var userInfo = new DBConnect();
            var myResult = userInfo.UpdateUserData();//.GetUserData();
            return myResult;
        }

        // POST: api/Home
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Home/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
