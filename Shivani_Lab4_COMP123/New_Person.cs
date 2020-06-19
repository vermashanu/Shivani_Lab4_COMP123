using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivani_Lab4_COMP123
{
    class New_Person
    {
        //Private instance variables
        private string m_name;
        private int m_age;
        private string m_contactNo;

        // Public properties
        public string Name
        {

            get 
            {
                return m_name;
            }

            set 
            {
                m_name = value;
            }
        }

        public int Age
        {
            get
            {
                return m_age;
            }

            set
            {
                m_age = value;
            }
        }
        public string ContactNo
        {
            get
            {
                return m_contactNo;
            }
            set
            {
                m_contactNo = value;
            }
        }




        // Constructor
        public New_Person(string name, int age,string contactNo)
        {
            m_name = name;
            m_age = age;
            m_contactNo = contactNo;
        }

        // Private methods

        // Public methods
        public void SaysHello()
        {
            Console.WriteLine($"{Name} says Hello");
        }

        public override string ToString()
        {
            string output = "";
            output += "\n++++++++++++++++++++++++++++\n";
            output += $" Name      : {Name}          \n";
            output += $" Age       : {Age}           \n";
            output += $"Contact no : {ContactNo}     \n";
            output += "++++++++++++++++++++++++++++++\n";
            return output;
        }
    }
}
