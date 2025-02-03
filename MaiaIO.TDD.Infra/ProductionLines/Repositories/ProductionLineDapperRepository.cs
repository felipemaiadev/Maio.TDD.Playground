using Dapper;
using MaiaIO.TDD.Domain.ProductionLines.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace MaiaIO.TDD.Infra.ProductionLines.Repositories
{
    public class ProductionLineDapperRepository : IProductionLineDapperRepository
    {
        public readonly IConfiguration _configuration;
        private static string connectionString = @"server=127.0.0.1;Port=3306;database=FTW;Uid=root;pwd=my-secret-pw;";

        public ProductionLineDapperRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        public async Task<int> ReportLinesInvetory()
        {
            var connection = new SqlConnection(_configuration.GetConnectionString("ConnectionString"));

            var report = await connection.QueryAsync<dynamic>("SELECT 1");

            return report.Count();
        }

    }
}
