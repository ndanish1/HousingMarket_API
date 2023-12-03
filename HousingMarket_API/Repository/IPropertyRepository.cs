using HousingMarket_API.Model;

namespace HousingMarket_API.Repository
{
    public interface IPropertyRepository
    {
        Task AddAsync(PropertyModel property);
        Task<IEnumerable<PropertyModel>> GetAllAsync();
        Task<PropertyModel> GetByIdAsync(int id);
        Task UpdateAsync(PropertyModel property);
        Task DeleteAsync(int id);
        Task PatchAsync(int id);

    }
}
