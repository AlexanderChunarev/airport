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

            var destination = new Destination()
            {
                AirlineId = input.Destination.AirlineId,
                Country = input.Destination.Country
            };
            await _destinationRepository.Add(destination);
            var airlineOutput = new DestinationOutput(destination);
            _outputHandler.Standard(airlineOutput);
        }
    }
}