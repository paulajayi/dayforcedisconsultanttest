using EmployeeRating.Lib.Core.Models;

namespace EmployeeRateCard.Models
{
	public class RateCardViewModel
	{
		public Guid Id { get; set; }
		public string Job { get; set; }
        public string Dept { get; set; }
		public DateTime EffectiveStart { get; set; }
		public DateTime EffectiveEnd { get; set; }
		public decimal HourlyRate { get; set; }

		public List<RateCardViewModel> convertToRateCardVMList(IEnumerable<RateCardModel> ratecards)
		{
			List<RateCardViewModel> rateCards = new();
			foreach (var ratecard in ratecards)
			{
				RateCardViewModel model = new()
				{
					Id = ratecard.Id,
					Job = ratecard.Job,
					Dept = ratecard.Dept,
					EffectiveStart = ratecard.EffectiveStart,
					EffectiveEnd = ratecard.EffectiveEnd,
					HourlyRate = ratecard.HourlyRate,
				};
				rateCards.Add(model);
            }
			return rateCards;

        }
	}
}
