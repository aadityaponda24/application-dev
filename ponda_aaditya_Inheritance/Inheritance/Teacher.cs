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
    // details about teacher, gives details about them
    class Teacher : Person
    {
        private string _city;
        private string _state;
        private string _zip;

        public Teacher(string name, string description, int age, string city, string state, string zip): base(name, description, age)
        {
            _city = city;
            _state = state;
            _zip = zip;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {_name} Age:{_age} Address: {_city},{_state} {_zip}");
        }
    }
}
