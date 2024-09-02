using EmployeeRateCard.Lib.Infrastucture;
using EmployeeRating.Lib.Domain.Entities;
using EmployeeRating.Lib.Domain.Repositories.Interface;
using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRating.Lib.Domain.Repositories.Implementaton
{
    public class RatecardRepository : IRatecardRepository
    {
        private readonly SqlDapperContext _context;

        public RatecardRepository(SqlDapperContext context)
        { 
            _context = context;
        }

        public async Task<IEnumerable<RateCards>> GetAllAsync()
        {
            var query = "SELECT * FROM RateCards";
            using var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<RateCards>(query);
            return result;
        }

        public async Task<RateCards> GetById(Guid id)
        {
            using var connection = _context.CreateConnection();
            var query = "SELECT * FROM RateCards WHERE Id=@Id";
            var parameters = new DynamicParameters();
            parameters.Add("Id", id);
            try
            {
                var retVal = await connection.QueryFirstOrDefaultAsync<RateCards>(query, parameters);
                return retVal;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Task<bool> InsertAsync(RateCards rateCards)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(RateCards rateCards)
        {
            throw new NotImplementedException();
        }
    }
}
