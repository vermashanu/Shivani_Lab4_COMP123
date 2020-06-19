using System;
using System.Collections.Generic;
using System.Text;

namespace Shivani_Lab4_COMP123
{
    class Tester : Employee
    {
        // Private instance variables 
        private string m_testName;

        // PUBLIC PROPERTIES

        public string Testname
        {

            get
            {
                return m_testName;
            }

            set
            {
                m_testName = value;
            }
        }
        // Constructor
        public Tester(string name, int age, string contactNo, string employee_id, string testName)
            : base(name, age, contactNo, employee_id)
        {
            Testname = testName;
        }

        // Private methods

        // Public methods
        public void Tests()
        {
            Console.WriteLine($"{Name} is running {Testname}.");
        }


        public override string ToString()
        {
            string output = "";

            output += "\n++++++++++++++++++++++++++++++++++++++++\n";
            output += $" Name           : {Name}                 \n";
            output += $" Age            : {Age}                  \n";
            output += $" Contact No     :{ContactNo}             \n";
            output += $" Employee Id    : {EmployeeID}           \n";
            output += $" Test name      : {Testname}          \n";
            output += "++++++++++++++++++++++++++++++++++++++++++\n";

            return output;
        }
    }
}
    
    
    

