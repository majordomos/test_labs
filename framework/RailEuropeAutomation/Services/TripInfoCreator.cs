using RailEurope.Models;
namespace RailEurope.Services
{
    public class TripInfoCreator
    {
        public static TripInfo SetInvalidInfo()
        {
            return new TripInfo(InvalidTestDataReader.GetData("DepartureStation"), InvalidTestDataReader.GetData("ArrivalStation")
                , InvalidTestDataReader.GetData("DepartureDay"));
        }
        public static TripInfo SetValidInfo()
        {
            return new TripInfo(ValidTestDataReader.GetData("DepartureStation"), ValidTestDataReader.GetData("ArrivalStation")
                , ValidTestDataReader.GetData("DepartureDay"));
        }
    }

}