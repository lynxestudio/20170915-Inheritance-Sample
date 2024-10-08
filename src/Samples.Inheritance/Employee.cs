
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Samples.Inheritance
{

    public class Employee
    {

        private DateTime birthDate;
        private string name;
        private double salary;

        public Employee()
        {

        }

        ~Employee()
        {

        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

        public string GetDetails()
        {

            return "\n\t[ Name ] " + Name + "\n\t[ Salary ] " + Salary + "\n\t[ BirthDate ] " + BirthDate.ToShortDateString();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

    }//end Employee
}