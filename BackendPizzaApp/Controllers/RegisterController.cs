using BackendPizzaApp.Models;
using BackendPizzaApp.Resources;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackendPizzaApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        // GET: api/<RegisterController>
        [HttpGet]
        public ActionResult<string[]> Get()
        {
            return new string[] { "ResponseOne", "ResponseTwo" };
        }

        // GET api/<RegisterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegisterController>
        [HttpPost]
        public void Post([FromBody] Users user)
        {
            try
            {
                Users.New.SetName(user.Name)
                    .SetLastname(user.Lastname)
                    .SetPassword(user.Password)
                    .SetTelephone(user.Telephone)
                    .SetRangePermitions(user.RangePermitions)
                    .BuildToLog().Register();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // PUT api/<RegisterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RegisterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
