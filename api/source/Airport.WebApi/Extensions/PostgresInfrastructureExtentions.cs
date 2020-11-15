using System.Data;
using Airport.Application.Repositories;
using Airport.Infrastructure.DapperDataAccess.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace Airport.WebApi.Extensions
{
    public static class PostgresInfrastructureExtensions
    {
        public static IServiceCollection AddPostgresPersistence(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(
                options => new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")));

            // Add repositories below
            services.AddScoped<IAirlineRepository, AirlineRepository>();
            services.AddScoped<IDestinationRepository, DestinationRepository>();
            return services;
        }
    }
}