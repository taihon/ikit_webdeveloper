using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public void Set(double d, double f)
        {
            _d = d;
            _f = f;
        }
        public override string ToString()
        {
            return "MyTestCLass";
        }
    }
    public class Reflect
    {
        public static void MethodReflexiveInfo<T>
            (T obj) where T : class
        {
            Type t = typeof(T);
            foreach (var mt in t.GetMethods())
            {
                Console.Write($"{mt.ReturnType.Name} {mt.Name} (");
                foreach (var p in mt.GetParameters())
                {
                    Console.Write($"{p.ParameterType.Name} {p.Name},");
                }
                Console.Write(") "+Environment.NewLine);
            }
        }
    }
}
