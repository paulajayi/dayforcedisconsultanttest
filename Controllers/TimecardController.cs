using EmployeeRateCard.Models;
using EmployeeRating.Lib.Core;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeRateCard.Controllers
{
	public class TimecardController : Controller
	{
        private readonly IRatingService _ratingService;
		List<TimeCardViewModel> _timeCardVMList = new();
		TimeCardViewModel timeCardVM = new();
        public TimecardController(IRatingService ratingService)
		{
			_ratingService = ratingService;
		}
        public async Task<IActionResult> Index()
		{
			var response = await _ratingService.GetTimeCards();
			_timeCardVMList = timeCardVM.ConverToTimeCardVMList(response.ToList());
           
            return View(_timeCardVMList);
		}
	}
}
