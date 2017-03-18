using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class Dispatcher
    {
        public static string Move(Auto a)
        {
            return string.Format("Sending cargo with auto: {0}", a.Title); 
        }
        public static string Move(AirCraft a)
        {
            return string.Format("Sending cargo with aircraft: {0}", a.Title);
        }
        public static string Move(ITouristTransport t)
        {
            return t.Move() + Environment.NewLine + "You may go now";
        }
    }
}
