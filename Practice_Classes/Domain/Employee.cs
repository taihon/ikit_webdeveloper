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
        private string _name;
        public double Salary {
            get { return SalaryCountHelper.SetSalary(_salary); }
            set { _salary = value; }
        }
        public string Name {
            get { return _name; }
            set {
                if (string.IsNullOrEmpty(_name))
                    _name = value;
            }
        }
        private int _yearOfBirth = 1989;
        public int Age { get { return DateTime.Now.Year - _yearOfBirth; } }
    }
    public static class SalaryCountHelper
    {
        public static double SetSalary(double salary)
        {
            return salary * .87;
        }
    }
}
