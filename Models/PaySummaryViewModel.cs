using EmployeeRating.Lib.Core.Models;

namespace EmployeeRateCard.Models
{
	public class PaySummaryViewModel
	{
        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public string EarningsCode { get; set; }
        public decimal TotalHours { get; set; }
        public decimal TotalPayAmount { get; set; }
        public decimal RateOfPay { get; set; }
        public string Job { get; set; }
        public string Dept { get; set; }

        public List<PaySummaryViewModel> ConvertToPaySummariesVMList (IEnumerable<PaySummaryModel> paySummaries)
        {
            List<PaySummaryViewModel> paySummariesList = new();
            foreach (var paySummary in paySummaries)
            {
                PaySummaryViewModel model = new()
                {
                    EmployeeName = paySummary.EmployeeName,
                    EmployeeNumber = paySummary.EmployeeNumber,
                    EarningsCode = paySummary.EarningsCode,
                    TotalHours = paySummary.TotalHours,
                    TotalPayAmount = paySummary.TotalPayAmount,
                    RateOfPay = paySummary.RateOfPay,
                    Job = paySummary.Job,
                    Dept = paySummary.Dept,
                };
                paySummariesList.Add(model);
            }
            return paySummariesList;
        }
    }
}
