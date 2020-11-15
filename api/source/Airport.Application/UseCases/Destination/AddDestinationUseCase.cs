using System.Linq;
using System.Threading.Tasks;
using Airport.Application.Boundaries.Destination;
using Airport.Application.Repositories;

namespace Airport.Application.UseCases.Destination
{
    using Airport.Domain.Destination;

    public class AddDestinationUseCase : IAddDestinationUseCase
    {
        private readonly IDestinationRepository _destinationRepository;
        private readonly IOutputPort _outputHandler;

        public AddDestinationUseCase(IDestinationRepository destinationRepository, IOutputPort outputHandler)
        {
            _destinationRepository = destinationRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(DestinationInput input)
        {
            if (input == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }

            var destinations = input.Destinations.Select(d =>
                new Destination()
                {
                    AirlineId = d.AirlineId,
                    Country = d.Country
                }).ToList();

            await _destinationRepository.Add(destinations);
            var airlineOutput = new DestinationOutput(destinations);
            _outputHandler.Standard(airlineOutput);
        }
    }
}