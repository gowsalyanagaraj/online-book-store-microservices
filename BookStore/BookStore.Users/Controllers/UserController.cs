using Microsoft.AspNetCore.Mvc;
using BookStore.Users.Models;
using BookStore.Users.DTO;

namespace BookStore.Users.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private static readonly List<User> users = new()
        {
            new User { Id = 1, Name = "John", Password = "aaa" },
            new User { Id = 2, Name = "Alice", Password = "aaa" },
            new User { Id = 3, Name = "Max", Password = "aaa" }
        };

        [HttpGet("userDetails")]
        public IActionResult GetUsers()
        {
            return Ok(users);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = users.FirstOrDefault(u =>
                u.Name == request.Name &&
                u.Password == request.Password);

            if (user != null)
            {
                return Ok(new
                {
                    Message = "User successfully logged in"
                });
            }

            return Unauthorized(new
            {
                Message = "Invalid username or password"
            });
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterRequest request)
        {
            var existingUser = users.FirstOrDefault(u =>
                u.Name.ToLower() == request.Name.ToLower());

            if (existingUser != null)
            {
                return BadRequest(new
                {
                    Message = "User already exists"
                });
            }

            var newUser = new User
            {
                Id = users.Max(u => u.Id) + 1,
                Name = request.Name,
                Password = request.Password
            };

            users.Add(newUser);

            return Ok(new
            {
                Message = "User registered successfully",
                User = newUser
            });
        }
    }
}