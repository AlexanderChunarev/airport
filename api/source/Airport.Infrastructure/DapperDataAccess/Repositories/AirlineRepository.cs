using System;
using System.Threading;
using System.Transactions;

namespace Airport.Infrastructure.DapperDataAccess.Repositories
{
    using System.Data;
    using System.Threading.Tasks;
    using Airport.Application.Repositories;
    using Airport.Domain.Airline;
    using Dapper;

    public class AirlineRepository : IAirlineRepository
    {
        private readonly IDbConnection _dbConnection;

        public AirlineRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task Add(Airline airline)
        {
            const string insertAirlineQuery =
                "INSERT INTO airlines (name, description) VALUES (@Name, @Description) RETURNING id";
            const string insertPlaneQuery =
                "INSERT INTO planes (airlineid, name, description) VALUES (@AirlineId, @Name, @Description)";
            using (var transaction = new TransactionScope())
            {
                var id = _dbConnection.QueryFirstAsync<int>(insertAirlineQuery, airline);
                await Task.WhenAll(id).ContinueWith(res =>
                {
                    foreach (var plane in airline.Planes)
                    {
                        plane.AirlineId = res.Result[0];
                        _dbConnection.Execute(insertPlaneQuery, plane);
                    }
                });
                transaction.Complete();
            }
        }

        public Task Delete(Airline airline)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Airline airline)
        {
            throw new System.NotImplementedException();
        }
    }
}