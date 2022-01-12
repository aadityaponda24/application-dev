/* 
 * Name: Aaditya Ponda
 * Date: Jan 10 2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /* Person parent class holds details about a person */
    class Person
    {
        protected string _name;
        protected string _description;
        protected int _age;

        public Person(string name, string description, int age)
        {
            _name = name;
            _description = description;
            _age = age;
        }
    }
}
