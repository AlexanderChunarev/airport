using Airport.Application.UseCases.Airline;
using Airport.Application.UseCases.Destination;
using Microsoft.Extensions.DependencyInjection;

namespace Airport.WebApi.Extensions
{
    public static class ApplicationExtensions
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddScoped<IAddAirlineUseCase, AddAirlineUseCase>();
            services.AddScoped<IAddDestinationUseCase, AddDestinationUseCase>();
           
            return services;
        }
    }
}

