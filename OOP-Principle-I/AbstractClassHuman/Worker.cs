using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClassHuman
{
    public class Worker : Human
    {
        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public Worker(int weekSalary, int workingHoursPerDay, string fName, string lName) 
            : base(fName, lName) 
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workingHoursPerDay;
        }

        public decimal MoneyPerHour()
        {
            decimal result = ((decimal)WeekSalary) / (decimal)(5 * WorkHoursPerDay);
            return result;
        }
    }
}
