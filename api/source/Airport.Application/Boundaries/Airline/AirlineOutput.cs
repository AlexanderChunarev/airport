namespace Airport.Application.Boundaries.Airline
{
    using Airport.Domain.Airline;
    public sealed class AirlineOutput
    {
        public Airline Airline { get; set; }

        public AirlineOutput(Airline airline)
        {
            Airline = airline;
        }
    }
}