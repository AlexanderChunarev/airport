using System.Threading.Tasks;
using Airport.Application.Boundaries.Airline;
using Airport.Application.Repositories;

namespace Airport.Application.UseCases.Airline
{
    using Airport.Domain.Airline;

    public class AddAirlineUseCase : IAddAirlineUseCase
    {
        private readonly IAirlineRepository _airlineRepository;
        private readonly IOutputPort _outputHandler;

        public AddAirlineUseCase(IAirlineRepository airlineRepository, IOutputPort outputHandler)
        {
            _airlineRepository = airlineRepository;
            _outputHandler = outputHandler;
        }

        public async Task Execute(AirlineInput airlineInput)
        {
            if (airlineInput == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }

            var airline = new Airline()
            {
                Name = airlineInput.Airline.Name,
                Description = airlineInput.Airline.Description,
                Planes = airlineInput.Airline.Planes
            };
            await _airlineRepository.Add(airline);
            var airlineOutput = new AirlineOutput(airline);
            _outputHandler.Standard(airlineOutput);
        }
    }
}