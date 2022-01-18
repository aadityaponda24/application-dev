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
    /* Salaried employee contains salary along with name and address */
    class Salaried : Employee
    {
        protected decimal _salary;

        public Salaried(string name, string address, decimal salary):base(name,address)
        {
            _salary = salary;
        }

        public override decimal CalculatePay()
        {
            return _salary;
        }
    }
}
