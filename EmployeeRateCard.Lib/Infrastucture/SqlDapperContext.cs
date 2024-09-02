using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRateCard.Lib.Infrastucture
{
    public class SqlDapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public SqlDapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection()
  => new SqlConnection(_connectionString);

       
    }
}
