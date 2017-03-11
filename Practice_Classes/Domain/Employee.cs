using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee
    {
        private int _salary;
        public int Salary {
            get { return _salary; }
            set { _salary = (int)(value * .87); }
        }
    }
}
