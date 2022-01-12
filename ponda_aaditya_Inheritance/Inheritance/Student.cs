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
    // details about student, gives details about them
    class Student : Person
    {
        private int _grade;

        public Student(string name, string description, int age, int grade) : base(name, description, age)
        {
            _grade = grade;
        }

        public void Display()
        {
            string studentString = String.Format("Name: {0,-20}  Age:{1,3}  Grade:{2,4}", _name, _age, _grade);
            Console.WriteLine(studentString);
        }

    }
}
