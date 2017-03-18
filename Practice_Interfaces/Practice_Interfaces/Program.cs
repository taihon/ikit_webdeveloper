using BL;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldView
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto c = new Car();
            c.Title = "Mersedes Benz";
            Dispatcher.Move(c);
        }
    }
}
