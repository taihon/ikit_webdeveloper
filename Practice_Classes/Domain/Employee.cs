using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee
    {
        private double _salary;
        public double Salary {
            get { return SalaryCountHelper.SetSalary(_salary); }
            set { _salary = value; }
        }
    }
    public static class SalaryCountHelper
    {
        public static double SetSalary(double salary)
        {
            return salary * .87;
        }
    }
}
