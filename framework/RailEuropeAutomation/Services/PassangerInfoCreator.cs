using RailEurope.Models;
namespace RailEurope.Services
{
    public class PassangerInfoCreator
    {
        public static PassangerInfo SetInvalidInfo()
        {
            return new PassangerInfo(InvalidTestDataReader.GetData("PassangerFirstName"), InvalidTestDataReader.GetData("PassangerLastName")
                , InvalidTestDataReader.GetData("PassangerCountry"));
        }
        public static PassangerInfo SetValidInfo()
        {
            return new PassangerInfo(ValidTestDataReader.GetData("PassangerFirstName"), ValidTestDataReader.GetData("PassangerLastName")
                , ValidTestDataReader.GetData("PassangerCountry"));
        }
    }

}
