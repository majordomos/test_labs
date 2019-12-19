using RailEurope.Models;
namespace RailEurope.Services
{
    public class CustomerInfoCreator
    {
        public static CustomerInfo SetInvalidInfo()
        {
            return new CustomerInfo(InvalidTestDataReader.GetData("PassangerFirstName"), InvalidTestDataReader.GetData("PassengerLastName"),
                InvalidTestDataReader.GetData("PassangerEmail"), InvalidTestDataReader.GetData("PassangerPhoneNumber"),
                InvalidTestDataReader.GetData("PassangerAddressLine"), InvalidTestDataReader.GetData("PassangerCity"),
                InvalidTestDataReader.GetData("PassangerContry"), InvalidTestDataReader.GetData("PassangerZipCode"));
        }
        public static CustomerInfo SetValidInfo()
        {
            return new CustomerInfo(ValidTestDataReader.GetData("PassangerFirstName"), ValidTestDataReader.GetData("PassengerLastName"),
                ValidTestDataReader.GetData("PassangerEmail"), ValidTestDataReader.GetData("PassangerPhoneNumber"),
                ValidTestDataReader.GetData("PassangerAddressLine"), ValidTestDataReader.GetData("PassangerCity"),
                ValidTestDataReader.GetData("PassangerContry"), ValidTestDataReader.GetData("PassangerZipCode"));
        }
        public static CustomerInfo SetCardValidInfo()
        {
            return new CustomerInfo(ValidTestDataReader.GetData("CustomerCardNumber"), ValidTestDataReader.GetData("CustomerCardMonthValidation"),
                ValidTestDataReader.GetData("CustomerCVVCode"), ValidTestDataReader.GetData("CustomerName"));
        }
    }

}
