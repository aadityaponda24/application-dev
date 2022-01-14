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
    class Manager: Salaried
    {
        private decimal _bonus;

        public Manager(string name, string address, decimal salary, decimal bonus):base(name,address, salary)
        {
            _bonus = bonus;
        }

        public override decimal CalculatePay()
        {
            return _salary + _bonus;
        }
    }
}
