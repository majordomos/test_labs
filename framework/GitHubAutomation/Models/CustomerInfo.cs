namespace RailEurope.Models
{
    public class CustomerInfo
    {
        public string firstName { get; }
        public string lastName { get; }
        public string emailAddress { get; }
        public string verifyEmailAddress { get; }
        public string phoneNumber { get; }
        public string addressLine { get; }
        public string yourCity { get; }
        public string yourCountry { get; }
        public string zipCode { get; }
        public string cardNumber { get; }
        public string cvvCode { get; }
        public string validDate { get; }
        public string cardOwnerName { get; }

        public CustomerInfo (string name, string surname, string email, string phone, string address, string city, string country, string zip)
        {
            firstName = name;
            lastName = surname;
            emailAddress = email;
            verifyEmailAddress = email;
            phoneNumber = phone;
            addressLine = address;
            yourCity = city;
            yourCountry = country;
            zipCode = zip;
        }

        public CustomerInfo (string card, string cvv, string date, string name)
        {
            cardNumber = card;
            cvvCode = cvv;
            validDate = date;
            cardOwnerName = name;
        }
    }
}
