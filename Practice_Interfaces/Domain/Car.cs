using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Car : Auto, ITouristTransport
    {
        public override string Drive()
        {
            return base.Drive() + Environment.NewLine +
                "Drive carefully, you're not a Truck";
        }

        string ITouristTransport.Move()
        {
            return Drive();
        }
    }
}
