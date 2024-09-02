using EmployeeRateCard.Models;
using EmployeeRating.Lib.Core;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeRateCard.Controllers
{
	public class HomeController : Controller
	{
        private readonly IRatingService _ratingService;		

        private readonly ILogger<HomeController> _logger;
		List<PaySummaryViewModel> _paySummariesListVM = new();
		PaySummaryViewModel PaySummaryVM = new();

        public HomeController(IRatingService ratingService, ILogger<HomeController> logger)
        {
            _ratingService = ratingService;
            _logger = logger;
        }

       

		public async Task<IActionResult> Index()
		{
			var ratingResponse = await _ratingService.GetRateCards();
            var timeCardresponse = await _ratingService.GetTimeCards();
            var summary = _ratingService.GeneratePaySummary(timeCardresponse.ToList(), ratingResponse.ToList());
            _paySummariesListVM = PaySummaryVM.ConvertToPaySummariesVMList(summary);
            return View(_paySummariesListVM);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
