using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRating.Lib.Core.Models
{
    public class PaySummaryModel
    {
        public string EmployeeName { get; set; }
        public string EmployeeNumber { get; set; }
        public string EarningsCode { get; set; }
        public decimal TotalHours { get; set; }
        public decimal TotalPayAmount { get; set; }
        public decimal RateOfPay { get; set; }
        public string Job { get; set; }
        public string Dept { get; set; }
    }
}
