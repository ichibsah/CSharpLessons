using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _028_Structs
{
    /*struct are sealed type, meaning they cant be inherited*/
    public struct sCustomer
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /**/
        sCustomer(int ID, string Name)
        {
            
        }

    }

    /*u can add the sealed keyword to make it not inheritable*/
    public class cCustomer
    {
        private int _id { get; set; }
        private static string _name { get; } 
        /*struct cant have parameterless constructor*/
        cCustomer()
        {
            this._id =123;
            this._name = "dsfd"; 
            
        }
        /*struct cant have destructor*/
        ~cCustomer()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            cCustomer c1 = new cCustomer();
            cCustomer._name = "sdf";
            cCustomer._id = 
        }
    }
}
