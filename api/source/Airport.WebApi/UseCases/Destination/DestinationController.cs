using System.Collections.Generic;
using System.Threading.Tasks;
using Airport.Application.Boundaries.Destination;
using Airport.Application.UseCases.Destination;
using Microsoft.AspNetCore.Mvc;

namespace Airport.WebApi.UseCases.Destination
{
    using Airport.Domain.Destination;

    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : Controller
    {
        private readonly IAddDestinationUseCase _addDestinationUseCase;
        private readonly DestinationPresenter _destinationPresenter;

        public DestinationController(IAddDestinationUseCase addDestinationUseCase,
            DestinationPresenter destinationPresenter)
        {
            _addDestinationUseCase = addDestinationUseCase;
            _destinationPresenter = destinationPresenter;
        }

        [HttpPost]
        public async Task<IActionResult> AddDestination([FromBody] List<Destination> destinations)
        {
            var destinationInput = new DestinationInput(destinations);
            await _addDestinationUseCase.Execute(destinationInput);
            return _destinationPresenter.ViewModel;
        }
    }
}