
using Airport.Application.Boundaries.Destination;
using Microsoft.AspNetCore.Mvc;

namespace Airport.WebApi.UseCases.Destination
{
    public sealed class DestinationPresenter : IOutputPort
    {
        public IActionResult ViewModel { get; private set; }

        public void Error(string message)
        {
            throw new System.NotImplementedException();
        }

        public void Standard(DestinationOutput output)
        {
            ViewModel = new JsonResult(output.Destinations);
        }
    }
}