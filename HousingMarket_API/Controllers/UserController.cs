using HousingMarket_API.Repository;
using HousingMarket_API.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using HousingMarket_API.DTO;
using Microsoft.AspNetCore.JsonPatch;

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

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserModel userModel)
        {
            await userRepository.AddAsync(userModel);

            return CreatedAtAction(nameof(Getusers), new { id = userModel.Id }, userModel);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> Getusers()
        {
            var users = await userRepository.GetAllAsync();

            if (users == null)
            {
                return NotFound();
            }
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyDTO>> GetById(int id)
        {
            var user = await userRepository.GetByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var userDTO = new UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserName= user.UserName,
                Password= user.Password,
                UserRole= user.UserRole
            };

            return Ok(userDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UserModel updatedUser)
        {
            if (id != updatedUser.Id)
            {
                return BadRequest("The provided ID does not match the property ID.");
            }

            await userRepository.UpdateAsync(updatedUser);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            await userRepository.DeleteAsync(id);

            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchUser(int id, [FromBody] JsonPatchDocument<UserModel> patchDocument)
        {
            var propertyToUpdate = await userRepository.GetByIdAsync(id);

            if (propertyToUpdate == null)
            {
                return NotFound();
            }

            patchDocument.ApplyTo(propertyToUpdate, ModelState);

            if (!TryValidateModel(propertyToUpdate))
            {
                return BadRequest(ModelState);
            }

            await userRepository.UpdateAsync(propertyToUpdate);

            return NoContent();
        }
    }

}
