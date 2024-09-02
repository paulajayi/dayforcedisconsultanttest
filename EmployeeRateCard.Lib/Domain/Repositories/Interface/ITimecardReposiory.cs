using EmployeeRating.Lib.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRating.Lib.Domain.Repositories.Interface
{
    public interface ITimecardReposiory
    {
        Task<IEnumerable<TimeCards>> GetAllAsync();
        Task<TimeCards> GetById(Guid id);
        Task<bool> InsertAsync(TimeCards timeCard);
        Task<bool> UpdateAsync(TimeCards timeCard);
    }
}
