namespace Airport.Application.UseCases.Airline
{
    using System.Threading.Tasks;
    using Airport.Application.Boundaries.Airline;

    public interface IAddAirlineUseCase
    {
        Task Execute(AirlineInput airlineInput);
    }
}