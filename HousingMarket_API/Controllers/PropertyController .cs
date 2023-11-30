using Azure;
using HousingMarket_API.DTO;
using HousingMarket_API.Model;
using HousingMarket_API.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HousingMarket_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyRepository propertyRepository;

        public PropertyController(IPropertyRepository repository)
        {
            propertyRepository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProperty([FromBody] PropertyModel propertyModel)
        {
            await propertyRepository.AddAsync(propertyModel);

            return CreatedAtAction(nameof(GetProperties), new { id = propertyModel.Id }, propertyModel);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PropertyModel>>> GetProperties()
        {
            var properties = await propertyRepository.GetAllAsync();

            if (properties == null)
            {
                return NotFound();
            }

            return Ok(properties);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PropertyDTO>> GetById(int id)
        {
            var property = await propertyRepository.GetByIdAsync(id);

            if (property == null)
            {
                return NotFound();
            }

            var propertyDTO = new PropertyDTO
            {
                Id = property.Id,
                PropertyType = property.PropertyType,
                PropertyAddress = property.PropertyAddress,
                Bedrooms = property.Bedrooms,
                Bathrooms = property.Bathrooms,
                SquareFootage = property.SquareFootage,
                Price = property.Price,
                PropertyDescription = property.PropertyDescription
        };

            return Ok(propertyDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProperty(int id, [FromBody] PropertyModel updatedProperty)
        {
            if (id != updatedProperty.Id)
            {
                return BadRequest("The provided ID does not match the property ID.");
            }

            await propertyRepository.UpdateAsync(updatedProperty);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProperty(int id)
        {
            await propertyRepository.DeleteAsync(id);

            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchProperty(int id, [FromBody] JsonPatchDocument<PropertyModel> patchDocument)
        {
            var propertyToUpdate = await propertyRepository.GetByIdAsync(id);

            if (propertyToUpdate == null)
            {
                return NotFound();
            }

            patchDocument.ApplyTo(propertyToUpdate, ModelState);

            if (!TryValidateModel(propertyToUpdate))
            {
                return BadRequest(ModelState);
            }

            await propertyRepository.UpdateAsync(propertyToUpdate);

            return NoContent();
        }
    }
}
