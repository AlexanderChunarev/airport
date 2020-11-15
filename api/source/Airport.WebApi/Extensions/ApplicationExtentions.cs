using Microsoft.Extensions.DependencyInjection;
using Airport.Application.UseCases.Airline;

namespace Airport.WebApi.Extentions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IAddAirlineUseCase, AddAirlineUseCase>();
           
            return services;
        }
    }
}

