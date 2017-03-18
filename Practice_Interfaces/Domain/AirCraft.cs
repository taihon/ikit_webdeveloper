using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class AirCraft
    {
        public string Title { get; set; }
        public virtual string Fly()
        {
            return string.Format("{0} flew ahead!", Title);
        }
    }
}
