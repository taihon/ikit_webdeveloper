using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MyTestClass
    {
        double _d, _f;

        public MyTestClass(double d, double f)
        {
            _d = d;
            _f = f;
        }
        public double Sum()
        {
            return _d + _f;
        }
        public void Info()
        {
            Console.WriteLine($"{_d}");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
