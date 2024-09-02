using EmployeeRating.Lib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRating.Lib.Domain.Repositories.Interface
{
    public interface IRatecardRepository
    {
        Task<IEnumerable<RateCards>> GetAllAsync();
        Task<RateCards> GetById(Guid id);
        Task<bool> InsertAsync(RateCards rateCards);
        Task<bool> UpdateAsync(RateCards rateCards);
    }
}
