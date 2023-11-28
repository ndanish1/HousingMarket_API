using HousingMarket_API.DTO;
using HousingMarket_API.Model;
using Microsoft.EntityFrameworkCore;

namespace HousingMarket_API.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly HousingMarketAPIDbContext _context;
        //private readonly List<PropertyModel> properties;

        public PropertyRepository(HousingMarketAPIDbContext context)
        {
            _context = context;
        }
        public void Add(PropertyModel property)
        {
            _context.Property.Add(property);
            _context.SaveChanges();
        }

        public IEnumerable<PropertyModel> GetAll()
        {
            return  _context.Property;
        }

        public PropertyModel GetById(int id)
        {
            return _context.Property.FirstOrDefault(p => p.Id == id);
        }
    }
}
