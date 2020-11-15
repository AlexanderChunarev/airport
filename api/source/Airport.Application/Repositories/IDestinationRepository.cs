using System.Collections.Generic;
using System.Threading.Tasks;
using Airport.Domain.Destination;

namespace Airport.Application.Repositories
{
    public interface IDestinationRepository
    {
        Task Add(List<Destination> destinations);
    }
}