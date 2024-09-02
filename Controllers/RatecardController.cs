using EmployeeRateCard.Models;
using EmployeeRating.Lib.Core;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeRateCard.Controllers
{
	public class RatecardController : Controller
	{
		private readonly IRatingService _ratingService;

		List<RateCardViewModel> rateCardVMList = new();
		RateCardViewModel rateCardVM = new();
        public RatecardController(IRatingService ratingService)
		{
			_ratingService = ratingService;
		}
		public async Task<IActionResult> Index()
		{
			var ratingResponse =await _ratingService.GetRateCards();
			rateCardVMList = rateCardVM.convertToRateCardVMList(ratingResponse);
            return View(rateCardVMList);
		}
	}
}
