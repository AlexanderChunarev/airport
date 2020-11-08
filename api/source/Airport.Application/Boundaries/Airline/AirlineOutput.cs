namespace Airport.Application.Boundaries.Airline
{
    public sealed class AirlineOutput
    {
        private Domain.Airline.Airline airline;

        public AirlineOutput(Domain.Airline.Airline airline)
        {
            this.airline = airline;
        }
    }
}