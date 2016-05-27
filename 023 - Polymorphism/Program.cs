using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*polymorphism in C# is actually method overriding using virtual and override keywords
 unlike in C++.
 * method hiding in C# using the keyword "new" is more like polymorphism in C++
 */

namespace _023___Polymorphism
{
    public class Employee
    {
        public string FirstName = "FN";
        public string Lastname = "LN";


        /*virtual keyword sets the methos that u want to be abe to override*/
        public virtual void PrintFullname()
        {
            Console.WriteLine("{0} {1}", FirstName, Lastname);
        }
    }
        
    public class PartTimeEmployee : Employee
    {
        /*the override keyword overides the virtual method*/
        public override void PrintFullname()
        {
            Console.WriteLine("{0} {1} - Part Time", FirstName, Lastname);
        }

    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullname()
        {
            Console.WriteLine("{0} {1} - full Time", FirstName, Lastname);
        }
    }
    public class TempPartTimeEmployee : Employee
    {
        public override void PrintFullname()
        {
            Console.WriteLine("{0} {1} - temp Time", FirstName, Lastname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TempPartTimeEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullname();
            }
        }
    }
}
