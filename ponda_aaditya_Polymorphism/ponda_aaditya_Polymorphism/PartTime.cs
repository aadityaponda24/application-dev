/* 
 * Name: Aaditya Ponda
 * Date: Jan 11 2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Polymorphism
{
    /* Part time employee extends hourly employee */
    class PartTime:Hourly
    {
        public PartTime(string name, string address, decimal payPerHour, decimal hoursPerWeek):base(name,address,payPerHour,hoursPerWeek)
        { }


    }
}
