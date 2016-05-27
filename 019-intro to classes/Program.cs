using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_intro_to_classes
{
    class Customer
    {
        string _firstname;
        string _lastname;

        /*constructor overload*/
        public Customer()
            : this("not provided", "not provided")
        { }
        
        public Customer(string Firstname, string Lastname)
        {
            this._firstname = Firstname;
            this._lastname = Lastname;
        }

        public void PrintFullname()
        {
            Console.WriteLine("fullname ={0}", this._firstname +" " + this._lastname);
        }

        /*destructors*/
        ~Customer()
        {
            //clean up code
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer("P1","T1");
            C1.PrintFullname();

            Customer C2 = new Customer();
            C2.PrintFullname();
        }
    }
}
