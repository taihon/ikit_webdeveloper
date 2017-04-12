using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using ReflexiveLibrary;

namespace Practice_Reflexion
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflect.MethodReflexiveInfo<MyTestClass>(new MyTestClass(3.0, 2.7));
            var v = new MyTestClass2();
            //v.UsedMethod();
            //v.DontUseMethod();
            Reflect2.MethodReflexiveInfo<MyTestClass2>(v);
            Console.Read();
        }
    }
}
