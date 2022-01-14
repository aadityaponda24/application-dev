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

        public string GetName()
        {
            return _name;
        }

        abstract public decimal CalculatePay();

        public Employee(string name, string address)
        {
            _name = name;
            _address = address;
        }

        public String GetEmployeeDetails()
        {
            string employeeDtls = string.Format("{0,-20}{1,-30}{2,-20:C2}", _name, _address, CalculatePay());
            return employeeDtls;
        }
    }
}
