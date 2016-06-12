using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration_Types
{
    class Program
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        enum Months : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
        /*By default the underlying type of each element in the enum is int. You can specify another integral numeric type by using a colon, as shown in the previous example. */
        [Flags]
        enum Days2
        {
            None = 0x0,
            Sunday = 0x1,
            Monday = 0x2,
            Tuesday = 0x4,
            Wednesday = 0x8,
            Thursday = 0x10,
            Friday = 0x20,
            Saturday = 0x40
        }
        class MyClass
        {
            Days2 meetingDays = Days2.Tuesday | Days2.Thursday;
        }
        
        static void Main(string[] args)
        {
            Days today = Days.Monday;
            int dayNumber = (int)today;
            Console.WriteLine("{0} is day number #{1}.", today, dayNumber);

            Months thisMonth = Months.Dec;
            byte monthNumber = (byte)thisMonth;
            Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);

            // Output:
            // Monday is day number #1.
            // Dec is month number #11.



        }
    }
}
