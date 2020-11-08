using Airport.Application.Boundaries.Airline;
using Microsoft.AspNetCore.Mvc;

namespace Airport.WebApi.UseCases.Airline 
{
    public sealed class AirlinePresenter : IOutputPort
    {
        public IActionResult ViewModel { get; private set; }
        
        public void Error(string message)
        {
            throw new System.NotImplementedException();
        }

        public void Standard(AirlineOutput output)
        {
            ViewModel = new JsonResult(output.Airline);
        }
    }
}