using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Bicycle : ITouristTransport
    {
        public string Model { get; set; }
        public string Move()
        {
            return string.Format("Leased bicycle {0} to tourist", Model);
        }
    }
}
