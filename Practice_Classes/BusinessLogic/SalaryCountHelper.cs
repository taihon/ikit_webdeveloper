﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class SalaryCountHelper
    {
        public static double SetSalary(double salary)
        {
            return salary * .87;
        }
    }
}
