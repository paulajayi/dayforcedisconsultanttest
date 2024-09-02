using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRating.Lib.Core.Models
{
    public class RateCardModel
    {
        public Guid Id { get; set; }
        public string Job { get; set; }
        public string Dept { get; set; }
        public DateTime EffectiveStart { get; set; }
        public DateTime EffectiveEnd { get; set; }
        public decimal HourlyRate { get; set; }
    }
}
