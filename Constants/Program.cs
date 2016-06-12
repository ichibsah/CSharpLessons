using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    static class Constants
    {
        public const double Pi = 3.14159;
        public static int SpeedOfLight = 300000; // km per sec.

    }
    class Program
    {
        static void Main()
        {
            double radius = 5.3;
            double area = Constants.Pi * (radius * radius);
            int secsFromSun = 149476000 / Constants.SpeedOfLight; // in km
            Constants.SpeedOfLight = 400000;
            Console.WriteLine(Constants.SpeedOfLight);
            /*
             The use of the class name qualifier helps ensure that you and others who use the constant understand that it is constant and cannot be modified.
             */
        }
    }
}
