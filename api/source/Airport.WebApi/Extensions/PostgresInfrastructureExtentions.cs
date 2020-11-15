using System.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using Airport.Application.Repositories;
using Airport.Infrastructure.DapperDataAccess.Repositories;

namespace Airport.WebApi.Extentions
{
    public static class PostgresInfrastructureExtensions
    {
        public static IServiceCollection AddPostgresPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(
                options => new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection")));
        
            // Add repositories below
            services.AddScoped<IAirlineRepository, AirlineRepository>();
            return services;
        }
    }
}

