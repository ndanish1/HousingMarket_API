using HousingMarket_API.DTO;
using HousingMarket_API.Model;

namespace HousingMarket_API.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly List<PropertyModel> properties;
        public PropertyRepository() 
        {
            properties = new List<PropertyModel>();
        }

        public void Add(PropertyModel property)
        {
            property.Id = properties.Count + 1; 
            properties.Add(property);
        }

        public IEnumerable<PropertyModel> GetAll()
        {
            return properties;
        }
    }
}
