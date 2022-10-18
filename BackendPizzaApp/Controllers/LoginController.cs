using BackendPizzaApp.Models;
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
    public class LoginController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult<Users> Get()
        {
            return Users.New.SetName("Moises").SetLastname("Camacho").SetTelephone("3325124512").BuildToLog();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value" + id;
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] Users user)
        {
            Users.New.SetName(user.Name)
                .SetPassword(user.Password)
                .BuildToLog().Login();
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
