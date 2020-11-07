namespace Airport.Application.Boundaries.Login
{
    public interface IOutputPort : IErrorHandler
    {
         void Standard();
    }
}