using EmployeeRating.Lib.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRating.Lib.Core
{
    public interface IRatingService
    {
        Task<IEnumerable<RateCardModel>> GetRateCards();
        Task<IEnumerable<TimeCardModel>> GetTimeCards();
        List<PaySummaryModel> GeneratePaySummary(List<TimeCardModel> timeCards, List<RateCardModel> rateCards);

    }
}
