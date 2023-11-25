using HousingMarket_API.DTO;
using HousingMarket_API.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HousingMarket_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> GetAll()
        {
            // Implement logic to get all housing data from the repository
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDTO> GetById(int id)
        {
            // Implement logic to get housing data by id from the repository
        }

        [HttpPost]
        public ActionResult<ProductDTO> Post([FromBody] ProductDTO housing)
        {
            // Implement logic to add new housing data to the repository
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProductDTO housing)
        {
            // Implement logic to update housing data in the repository
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] JsonPatchDocument<ProductDTO> patchDoc)
        {
            // Implement logic to apply partial updates to housing data in the repository
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Implement logic to delete housing data from the repository
        }
    }
}
