using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Drone:AirCraft, ITouristTransport
    {
        public override string Fly()
        {
            return base.Fly();
        }

        string ITouristTransport.Move()
        {
            return Fly();
        }
    }
}
