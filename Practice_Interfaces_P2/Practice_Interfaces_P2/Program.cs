using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interfaces_P2
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Manager { Name = "Jane Smith", Number = 3 };
            List<IInventoryable> l = new List<IInventoryable>
            {
                new Boss {Name="John Doe", Number=1 },
                m,
                new Press {Number=18 },
                new Papers { Number=0 }
            };
            try
            {
                l.Sort();
            }
            catch (Exception e)
            {

            }
            m.PropertyChanged += M_PropertyChanged;
            Revisor.Print(l);
            m.Name = "Sousan Doe";
        }

        private static void M_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine("Property {0} changed. New value {1}",e.PropertyName, ((Employee)sender).Name);
        }
    }
}
