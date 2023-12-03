using HousingMarket_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HousingMarket_API
{
    public class HousingMarketAPIDbContext : DbContext
    {
        public DbSet<PropertyModel> Property { get; set; } = null;

        public DbSet<UserModel> User { get; set; } = null;
        public HousingMarketAPIDbContext(DbContextOptions<HousingMarketAPIDbContext> options) : base(options)
        {
        }
    }
}
