using HousingMarket_API.DTO;
using HousingMarket_API.Model;

namespace HousingMarket_API.Repository
{
    public interface IPropertyRepository
    {
        void Add(PropertyModel property);
        IEnumerable<PropertyModel> GetAll();
        PropertyModel GetById(int id);
        /*void Update(PropertyModel housing);
        void Delete(int id);*/
    }
}
