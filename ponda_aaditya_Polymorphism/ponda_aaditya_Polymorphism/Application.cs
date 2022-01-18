/* 
 * Name: Aaditya Ponda
 * Date: Jan 11 2022
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponda_aaditya_Polymorphism
{
    
    class Application
    {
        /* Variable to store list of employees */
        private List<Employee> _employees;

        /* Mainmenu choices */
        private List<string> _menuChoices = new List<string>() { "Add Employee", "Remove Employee", "Display Payroll","Exit"};
        private Menu mainMenu;

        /* Add menu choices */
        private List<string> _addMenuChoices = new List<string>() { "Full Time", "Part Time", "Salaried", "Manager" };
        private Menu addMenu;

        /* Application constructor */
        public Application()
        {
            /* Setup main menu */
            mainMenu = new Menu(_menuChoices);
            addMenu = new Menu(_addMenuChoices);
            
            _employees = new List<Employee>();

            /* load employees from the file on starting of application */
            loadEmployees();

            /* get initial menu choice */
            int menuChoice = getMenuChoice(mainMenu);

            /* Repeat till user selects menu choice 4 */
            while(menuChoice != 4)
            {
                switch(menuChoice)
                {
                    case 1: addEmployee(); break;
                    case 2: removeEmployee(); break;
                    case 3: displayPayroll(); break;
                }

                menuChoice = getMenuChoice(mainMenu);
            }

        }

        /* Accept menu choice from user */
        private int getMenuChoice(Menu menu)
        {
            Console.Clear();
            Menu.DisplayHeader("Employee Tracker");
            menu.displayMenu(1);
            int menuSeletion = Validation.ValidateRange("Please enter your selection: ", 1, 4);
            return menuSeletion;

        }

        /* Add employee method */
        private void addEmployee()
        {
            int menuChoice = getMenuChoice(addMenu);
            if (menuChoice == 5)
                return;

            Console.Clear();
            string name = Validation.ValidateString("Please enter the name of the employee: ");
            string address = Validation.ValidateString("Please enter the address of the employee: ");

            if(menuChoice == 1) // Full Time
            {
                decimal payPerHour = Validation.ValidateNumber("Please enter pay per hour: ");
                _employees.Add(new FullTime(name, address, payPerHour));
            }
            else if(menuChoice == 2) // Part Time
            {
                decimal payPerHour = Validation.ValidateNumber("Please enter pay per hour: ");
                decimal hoursPerWeek = Validation.ValidateNumber("Please enter hours per week: ");
                _employees.Add(new PartTime(name,address, payPerHour,hoursPerWeek));
            }
            else if (menuChoice == 3) // Salaried
            {
                decimal salary = Validation.ValidateNumber("Please enter employee annual salary: ");
                _employees.Add(new Salaried(name, address, salary));
            }
            else if (menuChoice == 4) // Part Time
            {
                decimal salary = Validation.ValidateNumber("Please enter annual salary: ");
                decimal bonus = Validation.ValidateNumber("Please enter annual bonus: ");
                _employees.Add(new Manager(name, address, salary, bonus));
            }

            Console.WriteLine($"Employee {name} has been added");
            Menu.ReadKey();
        }

        /* Remove Employee Method */
        private void removeEmployee()
        {
            displayEmployees();
            Console.WriteLine();
            int menuChoice = Validation.ValidateRange("Please enter your selection: ",1, _employees.Count);
            _employees.RemoveAt(menuChoice - 1);
            Console.WriteLine("Employee has been terminated");
            Menu.ReadKey();
        }

        /* Display payroll makes use of display employees method */
        private void displayPayroll()
        {
            displayEmployees();
            Menu.ReadKey();
        }

        /* Display employee method */
        private void displayEmployees()
        {
            Console.Clear();
            Menu.DisplayHeader("Employee Tracker");
            Console.WriteLine("     Name                Address                       Pay");
            Console.WriteLine();
            for(int i=0; i<_employees.Count; i++)
            {
                Console.WriteLine($"{String.Format("{0,-5}",i+1)}{_employees[i].GetEmployeeDetails()}");
                Console.WriteLine();
            }
        }

        /* Load employees method for file loading of 3 employees */
        private void loadEmployees()
        {
            string employeeFileName = "../../../output/employees.txt";
            if(File.Exists(employeeFileName))
            {
                string[] lines = File.ReadAllLines(employeeFileName);
                foreach(string line in lines)
                {
                    string[] fields = line.Split(",");
                    string name = fields[0];
                    string address = fields[1];
                    decimal hoursPerWeek;
                    decimal.TryParse(fields[2],out hoursPerWeek);
                    Employee employee = new FullTime(name, address, hoursPerWeek);
                    _employees.Add(employee);
                }
            }
            Menu.ReadKey();
        }

    }
}
