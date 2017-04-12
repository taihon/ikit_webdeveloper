using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexiveLibrary
{
    [AttributeUsage(AttributeTargets.Method|AttributeTargets.Field)]
    public sealed class UserInfoAttribute : Attribute
    {
        public string Description;
        public UserInfoAttribute(string d)
        {
            Description = d;
        }
        public UserInfoAttribute()
        {

        }
    }
}
