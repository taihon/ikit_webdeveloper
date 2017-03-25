using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interfaces_P2
{
    
    public static class Revisor
    {
        public static void Print(IEnumerable<IInventoryable> list)
        {
            foreach (IInventoryable item in list)
            {
                Console.WriteLine("Number: {0}", item.Number);
            }
        }
    }
}
