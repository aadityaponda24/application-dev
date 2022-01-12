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
    abstract class Employee
    {
        private string _name;
        private string _address;

        abstract public decimal CalculatePay();

        public Employee(string name, string address)
        {
            _name = name;
            _address = address;
        }
    }
}
