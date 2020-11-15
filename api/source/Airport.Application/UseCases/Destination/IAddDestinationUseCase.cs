using System.Threading.Tasks;
using Airport.Application.Boundaries.Destination;

namespace Airport.Application.UseCases.Destination
{
    public interface IAddDestinationUseCase
    {
        Task Execute(DestinationInput input);
    }
}