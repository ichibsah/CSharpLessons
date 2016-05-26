using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021___Inheritance
{
    public class Employee
    {
        string FirstName;
        string Lastname;
        string Email;

        public void printFullName()
        {
            //
        }

        public Employee()
        {
    
        }

        public Employee( string message)
        {

        }

    }

    public class FullTimeEmployee : Employee
    {
        float YearlySalary;

        public FullTimeEmployee() : base("derived class controlling parent class")
        {
    
        }
    
    }



    /*only 1 base class allowed*/
    public class PartTimeEmplyee : Employee
    {
        float HourlyRate;
    }

    /*but multiple level inheritance is allowed*/
    public class MultipleLevel : FullTimeEmployee
    {
        int Holidays;
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.
        }
    }
}
