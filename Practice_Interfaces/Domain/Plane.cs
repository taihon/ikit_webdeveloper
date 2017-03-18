using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Plane : AirCraft
    {
        public override string Fly()
        {
            return base.Fly() + Environment.NewLine +
                "Don't forget to check altitude";
        }
    }
}
