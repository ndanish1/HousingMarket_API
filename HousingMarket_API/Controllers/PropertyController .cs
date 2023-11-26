using HousingMarket_API.DTO;
using HousingMarket_API.Model;
using HousingMarket_API.Repository;
using Microsoft.AspNetCore.Mvc;

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

        // POST: api/controller
        [HttpPost]
        public IActionResult CreateProperty([FromBody] PropertyModel propertyModel)
        {
            propertyRepository.Add(propertyModel);

            return CreatedAtAction(nameof(GetProperties), new { id = propertyModel.Id }, propertyModel);
        }

        // GET: api/properties
        [HttpGet]
        public IActionResult GetProperties()
        {
            var allProperties = propertyRepository.GetAll();
            return Ok(allProperties);
        }

        /*[HttpGet("{id}")]
        public ActionResult<PropertyDTO> GetById(int id)
        {
            // Implement logic to get housing data by id from the repository
        }



        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PropertyDTO housing)
        {
            // Implement logic to update housing data in the repository
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] JsonPatchDocument<PropertyDTO> patchDoc)
        {
            // Implement logic to apply partial updates to housing data in the repository
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Implement logic to delete housing data from the repository
        }*/
    }
}
