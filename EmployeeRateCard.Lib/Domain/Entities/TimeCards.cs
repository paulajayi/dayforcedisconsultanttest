using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRating.Lib.Domain.Entities
{
    public class TimeCards
    {
        [Key]
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

    }
}
