using EmployeeRating.Lib.Core.Models;

namespace EmployeeRateCard.Models
{
	public class TimeCardViewModel
	{
        public Guid Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public DateTime DateWorked { get; set; }
        public string EarningsCode { get; set; }
        public string JobWorked { get; set; }
        public string DeptWorked { get; set; }
        public decimal Hours { get; set; }
        public decimal Rate { get; set; }
        public decimal Bonus { get; set; }

        public List<TimeCardViewModel> ConverToTimeCardVMList(IEnumerable<TimeCardModel> timecards)
        {
            List<TimeCardViewModel> timeCards = new();
            foreach (var timecard in timecards)
            {
                TimeCardViewModel model = new()
                {
                    Id = timecard.Id,
                    EmployeeName = timecard.EmployeeName,
                    EmployeeNumber = timecard.EmployeeNumber,
                    DateWorked = timecard.DateWorked,
                    EarningsCode = timecard.EarningsCode,
                    JobWorked = timecard.JobWorked,
                    DeptWorked = timecard.DeptWorked,
                    Hours = timecard.Hours,
                    Rate = timecard.Rate,
                    Bonus = timecard.Bonus
                };
                timeCards.Add(model);
            }
            return timeCards;
        }
    }
}
