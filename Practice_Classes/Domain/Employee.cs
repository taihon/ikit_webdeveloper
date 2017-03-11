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
            get { return _salary; }
            set { _salary = value * .87; }
        }
    }
}
