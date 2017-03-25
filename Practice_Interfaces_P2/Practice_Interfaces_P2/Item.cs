using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interfaces_P2
{
    public abstract class Item : IInventoryable
    {
        public int Number { get; set; }

        public int CompareTo(object obj)
        {
            return Number - ((IInventoryable)obj).Number;
        }
    }
    public class Press:Item
    {

    }
    public class Papers :Item
    {

    }
}
