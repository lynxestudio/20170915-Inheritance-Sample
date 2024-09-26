using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Samples.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] options = {"Employee","Manager","Engineer","Secretary","Director"};
            Utilities.ShowMenu("Inheritance Sample",options);
            string selected = Utilities.Scanf("Select an option");
            Employee e = GetEmployee();
            switch (selected)
            {
                case "1":
                    ShowEmployee(e);
                    break;
                case "2":
                    ShowManager(e);
                    break;
                case "3":
                    ShowEngineer(e);
                    break;
                case "4":
                    ShowSecretary(e);
                    break;
                case "5":
                    ShowDirector(e);
                    break;
                default:
                    break;
            }
            Utilities.Pause();
        }

        private static Employee GetEmployee()
        {
            double salary;
            DateTime birthdate;
            string name = Utilities.Scanf("Name");
            string insalary = Utilities.Scanf("Salary");
            string inbirthdate = Utilities.Scanf("BirthDate");

            Double.TryParse(insalary, out salary);
            DateTime.TryParse(inbirthdate, out birthdate);

            return new Employee
            {
                Name = name,
                Salary = salary,
                BirthDate = birthdate
            };

        }

        private static void ShowDirector(Employee e)
        {
            string department = Utilities.Scanf("Department");
            Director d = new Director
            {
                Name = e.Name,
                Salary = e.Salary,
                BirthDate = e.BirthDate,
                Department = department
            };
            Utilities.PrintMessage("Details");
            Console.WriteLine(d.GetDetails());
            Console.WriteLine("\n\t[ Deparment ] " + d.Department);
        }

        private static void ShowSecretary(Employee e)
        {
            Console.WriteLine();
            Utilities.PrintMessage("Details");
            Console.WriteLine(e.GetDetails());
        }

        private static void ShowEngineer(Employee e)
        {
            Console.WriteLine();
            Utilities.PrintMessage("Details");
            Console.WriteLine(e.GetDetails());
        }

        private static void ShowManager(Employee e)
        {
            string department = Utilities.Scanf("Department");

            Manager m = new Manager
            {
                Name = e.Name,
                Salary = e.Salary,
                BirthDate = e.BirthDate,
                Department = department
            };
            Console.WriteLine();
            Utilities.PrintMessage("Details");
            Console.WriteLine(m.GetDetails());
            Console.WriteLine("\n\t[ Deparment ] " + m.Department);
        }

        private static void ShowEmployee(Employee e)
        {
            Console.WriteLine();
            Utilities.PrintMessage("Details");
            Console.WriteLine(e.GetDetails());
        }
    }
}
