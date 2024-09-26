

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Samples.Inheritance
{

    public class Manager : Employee
    {

        private string department;

        public Manager()
        {

        }

        ~Manager()
        {

        }

        

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

    }//end Manager
}