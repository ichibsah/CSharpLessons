using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*namespace by alias*/
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PATA.ClassA.Print();
            PATB.ClassA.Print();
        }
    }

}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print Method");
            }
        }
    }

    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B Print Method");
            }
        }
    }
}