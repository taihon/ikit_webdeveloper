using BL;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristView
{
    class Program
    {
        static void Main(string[] args)
        {
            ITouristTransport t = new Car();
            Dispatcher.Move(t);
        }
    }
}
