namespace Airport.Application.Repositories
{
    using System.Threading.Tasks;
    using Airport.Domain.Airline;

    public interface IAirlineRepository
    {
        Task Add(Airline airline);
        Task Update(Airline airline);
        Task Delete(Airline airline);
    }
}