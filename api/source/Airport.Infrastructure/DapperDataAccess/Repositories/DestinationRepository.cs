using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Transactions;
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

        public async Task Add(List<Destination> destinations)
        {
            const string insertDestinationQuery =
                "INSERT INTO destinations (airlineId, country) SELECT @AirlineId, @Country WHERE NOT EXISTS (SELECT airlineId, country FROM destinations WHERE airlineId=@AirlineId AND country=@country)";
            using (var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                foreach (var destination in destinations)
                {
                    await _dbConnection.ExecuteAsync(insertDestinationQuery, destination);
                }
                transaction.Complete();
            }
        }
    }
}