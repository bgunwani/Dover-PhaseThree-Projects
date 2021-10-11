using coreAPIServerProject.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coreAPIServerProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCorsPolicy")]
    public class UsersController : ControllerBase
    {
        ApplicationDBContext context;
        public UsersController()
        {
            context = new ApplicationDBContext();
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return context.Users.ToList();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return context.Users.Find(id);
        }

        // POST api/<UsersController>
        [HttpPost]
        public User Post([FromBody] User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        // PUT api/<UsersController>/5
        // [HttpPut("{id}")]
        public User Put([FromBody] User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
            return user;
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public User Delete(int id)
        {
            var user = context.Users.Find(id);
            context.Users.Remove(user);
            context.SaveChanges();
            return user;
        }
    }
}
