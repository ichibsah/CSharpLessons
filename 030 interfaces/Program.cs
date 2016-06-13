using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _030_interfaces
{
    /* they are public by defult, no access modifiers required*/
    interface ICustomer
    {
        void Print1();
    }
    /*an interface can inheret another interface, not a class*/
    interface I2method : ICustomer
    {
        void Print2();
    }

    /*class can inherit multiple interfaces*/
    class Customer : ICustomer, I2method
    {
        public void Print()
        {

        }

        public void Print2()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*this is legal since customer inherits Icustomer*/
            ICustomer Cust = new Customer();
            Cust.Print1();
        }
    }
}
