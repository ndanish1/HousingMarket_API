using HousingMarket_API.Model;

namespace HousingMarket_API.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }

        public UserDTO() { }
        public UserDTO(UserModel user)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName= user.LastName;
            Email = user.Email;
            UserName = user.UserName;
            Password = user.Password;
            UserRole= user.UserRole;
        }
    }
}
