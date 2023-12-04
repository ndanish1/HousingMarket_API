using HousingMarket_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace HousingMarket_API.Repository
{
    public interface IUserRepository
    {
        void Add(UserModel user);
        IEnumerable<UserModel> GetAll();
        UserModel GetById(int userId);
        void Update(UserModel user);
        void Delete(int userId);
        UserModel Authenticate(string username, string password);
    }
}
