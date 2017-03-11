using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class SalaryCountHelper
    {
        public static void SetSalary(Employee empl, double salary)
        {
            empl.Salary = salary * .87;
        }
    }
}
