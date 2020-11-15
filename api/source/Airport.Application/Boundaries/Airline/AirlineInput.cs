namespace Airport.Application.Boundaries.Airline
{
    using Airport.Domain.Airline;
    public sealed class AirlineInput
    {
        public Airline Airline { get; set; }

        public AirlineInput(Airline airline)
        {
            Airline = airline;
        }
    }
}