namespace Airport.Application.Boundaries.Destination
{
    public interface IOutputPort : IErrorHandler
    {
        void Standard(DestinationOutput output);
    }
}