using HousingMarket_API.Model;

namespace HousingMarket_API.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetAll();
        ProductModel GetById(int id);
        void Add(ProductModel housing);
        void Update(ProductModel housing);
        void Delete(int id);
    }
}
