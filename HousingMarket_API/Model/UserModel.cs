namespace HousingMarket_API.Model
{
    public class UserModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName{ get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public UserModel(int id, string firstName, string lastName, string userName, string email, string password, string userRole)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Email = email;
            Password = password;
            UserRole = userRole;
        }
    }
}
