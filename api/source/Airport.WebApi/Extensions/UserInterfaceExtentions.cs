namespace Airport.WebApi.Extentions
{
    using Microsoft.Extensions.DependencyInjection;
    using Airport.WebApi.UseCases.Airline;

    public static class UserInterfaceV1Extensions
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<Airport.WebApi.UseCases.Airline.AirlinePresenter, Airport.WebApi.UseCases.Airline.AirlinePresenter>();
            services.AddScoped<Airport.Application.Boundaries.Airline.IOutputPort>(x => x.GetRequiredService<Airport.WebApi.UseCases.Airline.AirlinePresenter>());
            return services;
        }
    }
}