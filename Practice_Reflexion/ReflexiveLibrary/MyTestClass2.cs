using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflexiveLibrary
{
    public class MyTestClass2
    {
        [Conditional("DEBUG")]
        [UserInfo("Cool method")]
        public void UsedMethod()
        {
            Console.WriteLine("You should use this method");
        }
        [Obsolete]
        [UserInfo("NotCool method")]
        public void DontUseMethod()
        {
            Console.WriteLine("You shouldn't use this method");
        }
    }

    public class Reflect2
    {
        public static void MethodReflexiveInfo<T>
            (T obj) where T : class
        {
            Type t = typeof(T);
            foreach (var mt in t.GetMethods())
            {
                var attribute = mt.GetCustomAttribute<UserInfoAttribute>();
                if (attribute !=null && attribute.Description.Equals("Cool method")) { 
                    Console.Write($"{mt.ReturnType.Name} {mt.Name} (");
                    foreach (var p in mt.GetParameters())
                    {
                        Console.Write($"{p.ParameterType.Name} {p.Name},");
                    }
                    Console.Write(") " + Environment.NewLine);
                    mt.Invoke(obj, null);
                }
            }
        }
    }
}
