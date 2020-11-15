using System.Data;
using System.Threading.Tasks;
using Airport.Application.Repositories;
using Airport.Domain.Destination;
using Dapper;

namespace Airport.Infrastructure.DapperDataAccess.Repositories
{
    public class DestinationRepository : IDestinationRepository
    {
        private readonly IDbConnection _dbConnection;

        public DestinationRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task Add(Destination destination)
        {
            const string insertDestinationQuery =
                "INSERT INTO destinations (airlineId, country) SELECT @AirlineId, @Country WHERE NOT EXISTS (SELECT airlineId, country FROM destinations WHERE airlineId=@AirlineId AND country=@country)";
            await _dbConnection.ExecuteAsync(insertDestinationQuery, destination);
        }
    }
}