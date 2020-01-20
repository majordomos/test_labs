namespace RailEurope.Models
{
    public class TripInfo
    {
        public string DepartureStation { get; }
        public string ArrivalStation { get; }
        public string DepartureDay { get; }

        public TripInfo( string departureStation, string arrivalStation, string departureDay)
        {
            DepartureStation = departureStation;
            ArrivalStation = arrivalStation;
            DepartureDay = departureDay;
        }
    }
}
