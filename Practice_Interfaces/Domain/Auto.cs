using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Auto
    {
        public string Title { get; set; }
        public virtual string Drive()
        {
            return string.Format("{0} went to route", Title);
        }
    }
}
