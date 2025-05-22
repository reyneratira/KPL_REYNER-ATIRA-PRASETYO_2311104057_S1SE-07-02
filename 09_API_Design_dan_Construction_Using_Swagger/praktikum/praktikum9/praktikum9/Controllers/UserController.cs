using Microsoft.AspNetCore.Mvc;
using praktikum9.Models;

namespace praktikum9.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static List <User> users = new List<User>
        {
            new User{id=1,name="Alisa", email = "alisa@gmail.com"},
            new User{id=2,name="Bob", email="bob@gmail.com" }
        };

        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return Ok(users);
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }
        [HttpPost]
        public ActionResult<User> CreateUser(UserDto createUser)
        {
            int newId = users.Max(u => u.id) + 1;
            User newUser = new User
            {
                id = newId,
                name = createUser.name,
                email = createUser.email
            };  
            users.Add(newUser);
            return Ok(newUser);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, UserDto updateUser)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            user.name = updateUser.name;
            user.email = updateUser.email;
            return Ok(user);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            users.Remove(user);
            return NoContent();
        }
    }
}
