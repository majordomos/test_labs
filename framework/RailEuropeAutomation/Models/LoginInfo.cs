namespace RailEurope.Models
{
    public class LoginInfo
    {
        public string Email { get; }
        public string Password { get; }

        public LoginInfo(string emailAdress, string passWord)
        {
            Email = emailAdress;
            Password = passWord;
        }
    }
}
