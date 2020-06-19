using System;
using System.Collections.Generic;
using System.Text;

namespace Shivani_Lab4_COMP123
{
    class Programmer : Employee
    {
        // Private instance variables 
        private string m_projectName;

        // PUBLIC PROPERTIES

        public string Projectname
        {

            get
            {
                return m_projectName;
            }

            set
            {
                m_projectName = value;
            }
        }
        // Constructor
        public Programmer(string name, int age, string contactNo, string employee_id,string projectName)
            : base(name, age, contactNo,employee_id)
        {
            Projectname = projectName;
        }

        // Private methods

        // Public methods
        public void Programs()
        {
            Console.WriteLine($"{Name} is working on {Projectname}.");
        }


        public override string ToString()
        {
            string output = "";

            output += "\n++++++++++++++++++++++++++++++++++++++++\n";
            output += $" Name           : {Name}                 \n";
            output += $" Age            : {Age}                  \n";
            output += $" Contact No     :{ContactNo}             \n";
            output += $" Employee Id    : {EmployeeID}           \n";
            output += $" Project Title  : {Projectname}          \n";
            output += "++++++++++++++++++++++++++++++++++++++++++\n";

            return output;
        }
    }
}
    
    
