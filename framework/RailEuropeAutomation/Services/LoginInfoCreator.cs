using RailEurope.Models;
namespace RailEurope.Services
{
    public class LoginInfoCreator
    {
        public static LoginInfo SetInvalidInfo()
        {
            return new LoginInfo(InvalidTestDataReader.GetData("LoginEmail"), InvalidTestDataReader.GetData("LoginPassword"));
        }
        public static LoginInfo SetValidInfo()
        {
            return new LoginInfo(ValidTestDataReader.GetData("LoginEmail"), ValidTestDataReader.GetData("LoginPassword"));
        }
    }

}
