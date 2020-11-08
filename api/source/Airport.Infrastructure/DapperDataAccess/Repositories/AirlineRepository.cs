namespace Airport.Infrastructure.DapperDataAccess.Repositories
{
    using System.Data;
    using System.Threading.Tasks;
    using Airport.Application.Repositories;
    using Airport.Domain.Airline;
    using Dapper;

    public class AirlineRepository : IAirlineRepository
    {
        private IDbConnection _dbConnection;

        public AirlineRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Task Add(Airline airline)
        {
            string query = "INSERT INTO airlines (name, description) VALUES (@Name, @Description) RETURNING *";
            return _dbConnection.QueryFirstAsync(query, airline);
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