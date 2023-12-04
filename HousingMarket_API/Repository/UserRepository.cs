using HousingMarket_API.Model;
using Microsoft.EntityFrameworkCore;

namespace HousingMarket_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly HousingMarketAPIDbContext _context;
        public UserRepository(HousingMarketAPIDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(UserModel user)
        {
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<UserModel>> GetAllAsync()
        {
            return await _context.User.ToListAsync();
        }
        public async Task<UserModel> GetByIdAsync(int id)
        {
            return await _context.User.FindAsync(id);
        }
        public async Task UpdateAsync(UserModel user)
        {
            _context.User.Update(user);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var userToDelete = await _context.User.FindAsync(id);

            if (userToDelete != null)
            {
                _context.User.Remove(userToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task PatchAsync(int id)
        {
            var userToPatch = await _context.User.FindAsync(id);

            if (userToPatch != null)
            {
                // Implement logic for patching (modify the entity as needed).

                await _context.SaveChangesAsync();
            }
        }
    }
}
