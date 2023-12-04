using HousingMarket_API.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HousingMarket_API.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly HousingMarketAPIDbContext _context;

        public UserRepository(HousingMarketAPIDbContext context)
        {
            _context = context;
        }

        public void Add(UserModel user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _context.User.ToList();
        }

        public UserModel GetById(int id)
        {
            return _context.User.FirstOrDefault(u => u.userId == id);
        }

        public void Update(UserModel user)
        {
            var existingUser = _context.User.FirstOrDefault(u => u.userId == user.userId);
            if (existingUser != null)
            {
                existingUser.firstName = user.firstName;
                existingUser.lastName = user.lastName;
                existingUser.userName = user.userName;
                existingUser.email = user.email;
                existingUser.password = user.password;
                existingUser.userRole = user.userRole;

                _context.SaveChanges();
            }
            else
            {
                
                throw new InvalidOperationException("The specified user does not exist.");
            }
        }

        public UserModel Authenticate(string username, string password)
        {
            return _context.User.FirstOrDefault(u => u.userName == username && u.password == password);
        }

        public void Delete(int id)
        {
            var user = _context.User.FirstOrDefault(u => u.userId == id);
            if (user != null)
            {
                _context.User.Remove(user);
                _context.SaveChanges();
            }
            else
            {

                throw new InvalidOperationException("The specified user does not exist.");
            }
        }
    }
}
