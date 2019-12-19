namespace RailEurope.Models
{
    public class PassangerInfo
    {
        public string firstName { get; }
        public string lastName { get; }
        public string yourCountry { get; }
        
        public PassangerInfo (string name, string surname, string country)
        {
            firstName = name;
            lastName = surname;
            yourCountry = country;
        }

    }
}
