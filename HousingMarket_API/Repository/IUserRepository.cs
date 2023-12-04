using HousingMarket_API.Model;

namespace HousingMarket_API.Repository
{
    public interface IUserRepository
    {
        Task AddAsync(UserModel user);
        Task<IEnumerable<UserModel>> GetAllAsync();
        Task<UserModel> GetByIdAsync(int id);
        Task UpdateAsync(UserModel user);
        Task DeleteAsync(int id);
        Task PatchAsync(int id);
    }
}
