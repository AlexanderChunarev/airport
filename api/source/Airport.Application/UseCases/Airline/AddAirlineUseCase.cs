namespace Airport.Application.UseCases.Airline
{
    using System.Threading.Tasks;
    using Airport.Application.Boundaries.Airline;
    using Airport.Application.Repositories;
    using Airport.Domain.Airline;

    public class AddAirlineUseCase : IAddAirlineUseCase
    {
        private readonly IAccountRepository _airlineRepository;
        private readonly IOutputPort _outputHandler;


        public async Task Execute(AirlineInput airlineInput)
        {
            if (airlineInput == null)
            {
                _outputHandler.Error("Input is null.");
                return;
            }
            var airline = new Airline() {
                Name = airlineInput.Airline.Name,
                Description = airlineInput.Airline.Description
            };

            AirlineOutput airlineOutput = new AirlineOutput(airline);
            await _airlineRepository.Add(airline);
            _outputHandler.Standard(airlineOutput);
        }

    }
}