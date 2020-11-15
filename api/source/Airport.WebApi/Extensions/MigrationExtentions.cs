using Airport.Infrastructure.DapperDataAccess.Migrations;
using FluentMigrator.Runner;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Airport.WebApi.Extensions
{
    public static class MigrationExtension
    {
        public static IServiceCollection AddMigration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddFluentMigratorCore()
                .ConfigureRunner( builder => 
                    builder.AddPostgres()
                        .WithGlobalConnectionString(configuration.GetConnectionString("DefaultConnection"))
                        .ScanIn(typeof(InitialMigration).Assembly).For.All()
                ).BuildServiceProvider();
            return services;
        }
        public static IApplicationBuilder Migrate(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();
            var runner = scope.ServiceProvider.GetService<IMigrationRunner>();
            runner.ListMigrations();
            runner.MigrateUp();
            return app;
        }
    }
}

