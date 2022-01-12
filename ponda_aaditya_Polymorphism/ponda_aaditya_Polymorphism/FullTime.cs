using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Polymorphism
{
    class FullTime : Hourly
    {
 
        public FullTime(string name, string address, decimal payPerHour):base(name,address, payPerHour,40)
        { }
    }
}
