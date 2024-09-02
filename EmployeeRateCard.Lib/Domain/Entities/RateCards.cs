using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRating.Lib.Domain.Entities
{
    public class RateCards
    {
        [Key]
        public Guid Id { get; set; }
        public string Job { get; set; }
        public string Dept { get; set; }
        public DateTime EffectiveStart { get; set; }
        public DateTime EffectiveEnd { get; set; }
        public decimal HourlyRate { get; set; }
    }
}
