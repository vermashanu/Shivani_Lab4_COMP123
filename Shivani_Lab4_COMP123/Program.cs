using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shivani_Lab4_COMP123
{
    class Program
    {
         static void Main(string[] args)
        {
            New_Person shiv = new New_Person("Shivani",22,"6472133455");

            shiv.SaysHello();
            string shivString = shiv.ToString();

            Console.WriteLine(shivString);
            Console.WriteLine();


            New_Person sahil = new New_Person("sahil",19,"9876543210");
            sahil.SaysHello();

            Console.WriteLine(sahil.ToString());
            Console.WriteLine();

            Employee sucharu = new Employee("sucharu", 27,"1234567890", "I04031992");

            sucharu.SaysHello();
            sucharu.Works();
            Console.WriteLine(sucharu.ToString());


            Programmer sucharuHasija = new Programmer("Sucharu",27,"1234567890", "I04031992", "Fitness App");
            sucharuHasija.SaysHello();
            sucharuHasija.Works();
            sucharuHasija.Programs();
            Console.WriteLine(sucharuHasija.ToString());

            Console.ReadLine();
        }
    }
}