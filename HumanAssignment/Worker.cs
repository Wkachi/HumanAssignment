using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanAssignment
{
    public class Worker : Human
    {
        public decimal Wage { get; set; }
        public int HoursWorked { get; set; }


        public decimal HourlyRate()
        {
            decimal HourlyRate = Wage * HoursWorked;
            return HourlyRate;
        }
    }
}