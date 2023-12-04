using HousingMarket_API.Repository;
using HousingMarket_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace HousingMarket_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : Controller
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository repository)
        {
            userRepository = repository;
        }

        // GET: api/properties1
        [HttpGet]
        public IActionResult GetUser()
        {
            var allProperties = userRepository.GetAll();
            return Ok(allProperties);
        }


        // POST
        [HttpPost]
        public IActionResult CreateUser([FromBody] UserModel userModel)
        {
            userRepository.Add(userModel);

            return CreatedAtAction(nameof(GetUser), new { id = userModel.userId }, userModel);
        }

        [HttpPost("authenticate")]
        public IActionResult AuthenticateLogin(string username, string password)
        {
            var authenticatedUser = userRepository.Authenticate(username, password);

            if (authenticatedUser == null)
            { 
                return Unauthorized();
            }

            return Ok(new { Message = "Authentication successful", User = authenticatedUser });
        }

        /////////////////////////////////////////////
        
        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] UserModel updatedUser)
        {
            var existingUser = userRepository.GetById(id);

            if (existingUser == null)
            {
                return NotFound(); // 404 Not Found
            }

            // Update user properties
            existingUser.firstName = updatedUser.firstName;
            existingUser.lastName = updatedUser.lastName;
            existingUser.userName = updatedUser.userName;
            existingUser.email = updatedUser.email;
            existingUser.password = updatedUser.password;
            existingUser.userRole = updatedUser.userRole;

            userRepository.Update(existingUser); 
            return Ok(existingUser);
        }

        // DELETE: api/user/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var userToDelete = userRepository.GetById(id);

            if (userToDelete == null)
            {
                return NotFound(); // 404 Not Found
            }

            userRepository.Delete(id); 
            return NoContent(); // 204 No Content
        }
    }

}
