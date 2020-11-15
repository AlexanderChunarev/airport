using Airport.WebApi.UseCases.Airline;
using Airport.WebApi.UseCases.Destination;
using Microsoft.Extensions.DependencyInjection;

namespace Airport.WebApi.Extensions
{
    public static class UserInterfaceV1Extensions
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<AirlinePresenter, AirlinePresenter>();
            services.AddScoped<Application.Boundaries.Airline.IOutputPort>(x => x.GetRequiredService<AirlinePresenter>());
            services.AddScoped<DestinationPresenter, DestinationPresenter>();
            services.AddScoped<Application.Boundaries.Destination.IOutputPort>(x => x.GetRequiredService<DestinationPresenter>());
            return services;
        }
    }
}