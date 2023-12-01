namespace HousingMarket_API.Model
{
    public class UserModel
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public string userName{ get; set; }
        public string password { get; set; }
        public string userRole { get; set; }


        public UserModel(int userId, string firstName, string lastName, string userName, string email, string password, string userRole)
        {
            this.userId = userId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.email = email;
            this.password = password;
            this.userRole = userRole;
            
        }


    }
}
