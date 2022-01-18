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
    /* Full time class extends Hourly */
    class FullTime : Hourly
    {
        /* Number of hours is assumed 40 for fulltime */
         public FullTime(string name, string address, decimal payPerHour):base(name,address, payPerHour,40)
        { }
    }
}
