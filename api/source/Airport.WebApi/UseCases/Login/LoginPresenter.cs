using Airport.Application.Boundaries.Login;
using Microsoft.AspNetCore.Mvc;

namespace Airport.WebApi.UseCases 
{
    public sealed class LoginPresenter : IOutputPort
    {
        public IActionResult ViewModel { get; private set; }
        public void Error(string message)
        {
            throw new System.NotImplementedException();
        }

        public void Standard()
        {
            throw new System.NotImplementedException();
        }
    }
}