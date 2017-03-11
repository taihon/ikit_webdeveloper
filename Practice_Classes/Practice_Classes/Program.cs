using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var empl = new Employee();
            empl.Salary = 5000;
            Console.WriteLine("Salary: "+empl.Salary);
            Console.WriteLine("Age: "+empl.Age);
        }
    }
}
