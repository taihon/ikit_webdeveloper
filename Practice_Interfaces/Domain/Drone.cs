using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Drone:AirCraft
    {
        public override string Fly()
        {
            return base.Fly() + Environment.NewLine +
                "Fly carefully, you're so light";
        }
    }
}
