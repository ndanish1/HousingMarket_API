using HousingMarket_API.Model;
using Microsoft.EntityFrameworkCore;

namespace HousingMarket_API.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly HousingMarketAPIDbContext _context;
        public PropertyRepository(HousingMarketAPIDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(PropertyModel property)
        {
            await _context.Property.AddAsync(property);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<PropertyModel>> GetAllAsync()
        {
            return await _context.Property.ToListAsync();
        }
        public async Task<PropertyModel> GetByIdAsync(int id)
        {
            return await _context.Property.FindAsync(id);
        }
        public async Task UpdateAsync(PropertyModel property)
        {
            _context.Property.Update(property);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var propertyToDelete = await _context.Property.FindAsync(id);

            if (propertyToDelete != null)
            {
                _context.Property.Remove(propertyToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task PatchAsync(int id)
        {
            var propertyToPatch = await _context.Property.FindAsync(id);

            if (propertyToPatch != null)
            {
                // Implement logic for patching (modify the entity as needed).

                await _context.SaveChangesAsync();
            }
        }
    }
}
