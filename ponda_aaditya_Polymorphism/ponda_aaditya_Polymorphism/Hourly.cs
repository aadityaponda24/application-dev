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
    /* Hourly employee conaints pay per hour and hours per week */
    abstract class Hourly : Employee
    {
        protected decimal _payPerHour;
        protected decimal _hoursPerWeek;

        public Hourly(string name, string address, decimal payPerHour, decimal hoursPerWeek):base(name,address)
        {
            _payPerHour = payPerHour;
            _hoursPerWeek = hoursPerWeek;
        }

        public override decimal CalculatePay()
        {
            return _payPerHour * _hoursPerWeek * 52;
        }
    }
}
