namespace Airport.Application.Boundaries.Airline
{
    public interface IOutputPort : IErrorHandler
    {
         void Standard(AirlineOutput output);
    }
}