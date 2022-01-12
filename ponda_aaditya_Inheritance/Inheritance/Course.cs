/* 
 * Name: Aaditya Ponda
 * Date: Jan 10 2022
 */
using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Course
    {
        /* Course will have title, description, teacher and lilst of students */
        private string _title;
        private string _description;
        private Teacher _teacher;
        private Student[] _students;

        public void SetTeacher(Teacher teacher)
        {
            _teacher = teacher;
        }

        public int getNoOfStudents()
        {
            return _students.Length;
        }

        public void SetStudents(Student[] students)
        {
            this._students = students;
        }

        /* Course Constructor */
        public Course(string title, string description, int noOfStudents)
        {
            _title = title;
            _description = description;
            _students = new Student[noOfStudents];
        }

        public void Display()
        {
            Console.WriteLine($"Course: {_title}");
            Console.WriteLine();

            Console.WriteLine("Teacher:");
            _teacher.Display();
            Console.WriteLine();

            Console.WriteLine("Students:");
            Console.WriteLine();
            for (int i = 0; i < getNoOfStudents(); i++)
            {
                _students[i].Display();
            }
        }

    }
}