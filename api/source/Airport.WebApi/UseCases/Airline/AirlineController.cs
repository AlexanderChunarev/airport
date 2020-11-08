using Airport.Application.UseCases.Airline;
using Microsoft.AspNetCore.Mvc;

namespace Airport.WebApi.UseCases.Airline
{
    using System.Threading.Tasks;
    using Airport.Application.Boundaries.Airline;
    using Airport.Domain.Airline;

    [Route("api/[controller]")]
    [ApiController]
    public class AirlineController : Controller
    {
        private readonly IAddAirlineUseCase _addAirlineUseCase;
        private readonly AirlinePresenter _airlinePresenter;

        public AirlineController(IAddAirlineUseCase addAirlineUseCase, AirlinePresenter airlinePresenter)
        {
            _addAirlineUseCase = addAirlineUseCase;
            _airlinePresenter = airlinePresenter;
        }

        [HttpPost]
        public async Task<IActionResult> AddAirline([FromBody] Airline airline)
        {
            var airlineInput = new AirlineInput(airline);
            await _addAirlineUseCase.Execute(airlineInput);
            return _airlinePresenter.ViewModel;
        }
    }
}