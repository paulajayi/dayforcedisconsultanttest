using Dapper;
using EmployeeRateCard.Lib.Infrastucture;
using EmployeeRating.Lib.Domain.Entities;
using EmployeeRating.Lib.Domain.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRating.Lib.Domain.Repositories.Implementaton
{
    public class TimecardReposiory : ITimecardReposiory
    {
        private readonly SqlDapperContext _context;
        public TimecardReposiory(SqlDapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<TimeCards>> GetAllAsync()
        {
            var query = "SELECT * FROM TimeCards";
            using var connection = _context.CreateConnection();
            var result = await connection.QueryAsync<TimeCards>(query);
            return result;
        }

        public async Task<TimeCards> GetById(Guid id)
        {
            using var connection = _context.CreateConnection();
            var query = "SELECT * FROM TimeCards WHERE Id=@Id";
            var parameters = new DynamicParameters();
            parameters.Add("Id", id);
            try
            {
                var retVal = await connection.QueryFirstOrDefaultAsync<TimeCards>(query, parameters);
                return retVal;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<bool> InsertAsync(TimeCards timeCard)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TimeCards timeCard)
        {
            throw new NotImplementedException();
        }
    }
}
