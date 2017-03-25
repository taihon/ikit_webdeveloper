using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Interfaces_P2
{
    public interface IInventoryable:IComparable
    {
        int Number { get; set; }
    }
}
