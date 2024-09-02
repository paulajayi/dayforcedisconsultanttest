using EmployeeRating.Lib.Core.Models;
using EmployeeRating.Lib.Domain.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRating.Lib.Core
{
    public class RatingService : IRatingService
    {
        private readonly IRatecardRepository _rategcardRepository;
        private readonly ITimecardReposiory _timecardReposiory;

        public RatingService(IRatecardRepository rategcardRepository, ITimecardReposiory timecardReposiory)
        {
            _rategcardRepository = rategcardRepository;
            _timecardReposiory = timecardReposiory;
        }


        public async Task<IEnumerable<RateCardModel>> GetRateCards()
        {
            try
            {
                var response = await _rategcardRepository.GetAllAsync();
                List<RateCardModel> rateCardList = new();
                foreach (var rateCard in response) 
                {
                    RateCardModel model = new()
                    {
                        Id = rateCard.Id,
                        Job = rateCard.Job,
                        Dept = rateCard.Dept,
                        EffectiveStart = rateCard.EffectiveStart,
                        EffectiveEnd = rateCard.EffectiveEnd,
                        HourlyRate = rateCard.HourlyRate,
                    };
                    rateCardList.Add(model);
                }
                return rateCardList;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<TimeCardModel>> GetTimeCards()
        {
            try
            {
                var response = await _timecardReposiory.GetAllAsync();
                List<TimeCardModel> timeCardList = new();
                foreach(var timeCard in response)
                {
                    TimeCardModel model = new()
                    {
                        Id = timeCard.Id,
                        EmployeeName = timeCard.EmployeeName,
                        EmployeeNumber = timeCard.EmployeeNumber,
                        DateWorked = timeCard.DateWorked,
                        EarningsCode = timeCard.EarningsCode,
                        JobWorked = timeCard.JobWorked,
                        DeptWorked = timeCard.DeptWorked,
                        Hours = timeCard.Hours,
                        Rate = timeCard.Rate,
                        Bonus = timeCard.Bonus,
                    };
                    timeCardList.Add(model);
                }
                return timeCardList;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public  List<PaySummaryModel> GeneratePaySummary(List<TimeCardModel> timeCards, List<RateCardModel> rateCards)
        {
            var summaryRecordList = new List<PaySummaryModel>();
            var groupedTimeCards = timeCards.GroupBy(x => new
            {
                x.EmployeeName,
                x.EmployeeNumber,
                x.EarningsCode,
                x.JobWorked,
                x.DeptWorked
            });

            foreach (var group in groupedTimeCards)
            {
                var employeeName = group.Key.EmployeeName;
                var employeeNumber = group.Key.EmployeeNumber;
                var earningsCode = group.Key.EarningsCode;
                var jobWorked = group.Key.JobWorked;
                var deptWorked = group.Key.DeptWorked;
                
                var rateCard = rateCards.FirstOrDefault(rc =>
                    rc.Job == jobWorked &&
                    rc.Dept == deptWorked &&
                    group.First().DateWorked >= rc.EffectiveStart &&
                    group.First().DateWorked <= rc.EffectiveEnd);

                if (rateCard == null)
                {
                    continue; 
                }               

                decimal payCodeMultiplier;
                switch (earningsCode)
                {
                    case "Overtime":
                        payCodeMultiplier = 1.5m;
                        break;
                    case "Double time":
                        payCodeMultiplier = 2.0m;
                        break;
                    default:
                        payCodeMultiplier = 1.0m; //Regular
                        break;

                }
                var totalHours = group.Sum(x => x.Hours);
                var totalPayAmount = group.Sum(x => (x.Hours * rateCard.HourlyRate * payCodeMultiplier) + x.Bonus);               
                var summaryRecord = new PaySummaryModel
                {
                    EmployeeName = employeeName,
                    EmployeeNumber = employeeNumber,
                    EarningsCode = earningsCode,
                    TotalHours = totalHours,
                    TotalPayAmount = totalPayAmount,
                    RateOfPay = rateCard.HourlyRate,
                    Job = jobWorked,
                    Dept = deptWorked
                };
                summaryRecordList.Add(summaryRecord);
            }            
            return summaryRecordList;
        }
    }
}
