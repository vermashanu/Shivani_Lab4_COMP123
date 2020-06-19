using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivani_Lab4_COMP123
{
    class Employee : New_Person
    {
        // Private instance variables 
        private string m_empID;

        // PUBLIC PROPERTIES

        public string EmployeeID
        {

            get 
            {
                return m_empID;
            }

            set 
            {
                m_empID = value;
            }
        }


        // Constructor
        public Employee(string name, int age, string contactNo, string employee_id)
            : base(name, age , contactNo)
        {
            m_empID = employee_id;
        }

        // Private methods

        // Public methods
        public void Works()
        {
            Console.WriteLine($"{Name} is working.");
        }

       
        public override string ToString()
        {
            string outputString = "";

            outputString += "\n++++++++++++++++++++++++++++++++++\n";
            outputString += $" Name        : {Name}              \n";
            outputString += $" Age         : {Age}               \n";
            outputString += $" Contact No  :{ContactNo}          \n";
            outputString += $" EmployeeID  : {EmployeeID}        \n";
            outputString += "++++++++++++++++++++++++++++++++++++\n";

            return outputString;
        }
    }
}
    