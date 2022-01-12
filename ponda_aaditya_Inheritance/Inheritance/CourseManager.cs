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
    class CourseManager
    {
        /* Current Course and Course Menu Fields */
        private Course _currentCourse;
        private Menu _courseMenu;

        /* Course Manager Constructor */
        public CourseManager()
        {
            List<string> menuItems = new List<string>() { "Create Course", "Create Teacher", "Add Students", "Display", "Exit" };
            _courseMenu = new Menu(menuItems);
            SetupMenu();

            /* Request Menu Choice from user */
            int menuChoice = Validation.ValidateRange("Please enter your selection: ", 1, 5);

            while (menuChoice != 5)
            {
                /* Take Action based on the menu choice */
                Console.Clear();
                switch(menuChoice)
                {
                    case 1: CreateCourse(); break;
                    case 2: CreateTeacher(); break;
                    case 3: AddStudents(); break;
                    case 4: Display(); break;
                }

                /* Read Menu Choice for next round */
                SetupMenu();
                menuChoice = Validation.ValidateRange("Please enter your selection: ", 1, 5);
            }
        }

        /* Setup Menu for Course */
        private void SetupMenu()
        {
            Console.Clear();
            Menu.DisplayHeader("Course Tracker");
            _courseMenu.displayMenu(1);
        }

        /* Create a course with title, description and no of students */
        private void CreateCourse()
        {
            string title = Validation.ValidateString("Please enter the title of the course: ");
            string description = Validation.ValidateString("Please enter the description of the course: ");
            int noOfStudents = Validation.ValidateNumber("Please enter the number of students: ");

            _currentCourse = new Course(title, description, noOfStudents);
            Console.WriteLine($"{title} course has been created.");

            Menu.ReadKey();
        }

        /* Create teacher with name, description, age and address */
        private void CreateTeacher()
        {
            if(_currentCourse is null)
            {
                Console.WriteLine("Please add course information before adding teacher");
                Menu.ReadKey();
                return;
            }

            string name = Validation.ValidateString("Please enter the name of the teacher: ");
            string description = Validation.ValidateString("Please enter the description of the teacher: ");
            int age = Validation.ValidateNumber("Please enter the age of the teacher: ");
            string city = Validation.ValidateString("Please enter the city: ");
            string state = Validation.ValidateString("Please enter the state abbreviation: ");
            string zip = Validation.ValidateString("Please enter the zip: ");

            Teacher teacher = new Teacher(name, description, age, city, state, zip);
            _currentCourse.SetTeacher(teacher);

            Console.WriteLine();
            Console.WriteLine($"{name} has been created.");

            Menu.ReadKey();
        }

        /* Add Students to the course */
        private void AddStudents()
        {
            if (_currentCourse is null)
            {
                Console.WriteLine("Please add course information before adding students");
                Menu.ReadKey();
                return;
            }

            int noOfStudents = _currentCourse.getNoOfStudents();
            Student[] students = new Student[noOfStudents];
            for (int i=0; i< noOfStudents; i++)
            {
                Console.WriteLine($"*** Student {i + 1} of {noOfStudents} ***");
                Console.WriteLine("");

                string name = Validation.ValidateString("Please enter the name of the student: ");
                string description = Validation.ValidateString("Please enter the description of the student: ");
                int age = Validation.ValidateNumber("Please enter the age of the student: ");
                int grade = Validation.ValidateNumber("Please enter the grade of the student: ");

                Student student = new Student(name, description, age, grade);
                students[i] = student;

                Console.WriteLine($"{name} has been added.");
                Console.WriteLine();
            }

            _currentCourse.SetStudents(students);
            Menu.ReadKey();
        }

        /* Display Course, Teacher and Students Information */
        private void Display()
        {
            Console.Clear();
            Menu.DisplayHeader("Course Tracker");
            _currentCourse.Display();
            Menu.ReadKey();
        }
    }
}
