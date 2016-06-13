using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_format
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Create DateTime for March 14,3057.
            DateTime time = new DateTime(3057, 3, 14);
            // One M.
            WriteLine(time.ToString("M"));
            // Use MM code.
	WriteLine(new DateTime(3057, 3, 14).ToString("MM"));
            // Use MMM code.
	WriteLine(new DateTime(3057, 3, 14).ToString("MMM"));
            // Use MMMM code.
	WriteLine(new DateTime(3057, 3, 14).ToString("MMMM"));
            // Use d code.
	WriteLine(new DateTime(3057, 3, 14).ToString("d"));
            // Use dd code.
	WriteLine(new DateTime(3057, 3, 14).ToString("dd"));
            // Use ddd code.
	WriteLine(new DateTime(3057, 3, 14).ToString("ddd"));
            // Use dddd code.
	WriteLine(new DateTime(3057, 3, 14).ToString("dddd"));
            // Use yy code.
	WriteLine(new DateTime(3057, 3, 14).ToString("yy"));
            // Use yyy code.
	WriteLine(new DateTime(3057, 3, 14).ToString("yyy"));
            // Use m code. March 14
	WriteLine(new DateTime(3057, 3, 14).ToString("m"));

            DateTime now = DateTime.Now;
	// Use mm code. 12/5/2015 1:34:26 PM [HH] = 13
	string result = now.ToString("mm");
	WriteLine($"{now} [mm] = {result}");

            DateTime time = DateTime.Now;             // Use current time.
	string format = "MMM ddd d HH:mm yyyy";   // Use this format.
	Console.WriteLine(time.ToString(format)); // Write to console.
            /*
             MMM     display three-letter month
ddd     display three-letter day of the WEEK
d       display day of the MONTH
HH      display two-digit hours on 24-hour scale
mm      display two-digit minutes
yyyy    display four-digit year
             */

            DateTime time = DateTime.Now;
	string format = "M d h:mm yy";
	Console.WriteLine(time.ToString(format));
            /*
             Format string pattern

M       display one-digit month number
d       display one-digit day of the month
h       display one-digit hour on 12-hour scale
mm      display two-digit minutes
yy      display two-digit year
             */

            DateTime now = DateTime.Now;
	Console.WriteLine(now.ToString("d"));
	Console.WriteLine(now.ToString("D"));
	Console.WriteLine(now.ToString("f"));
	Console.WriteLine(now.ToString("F"));
	Console.WriteLine(now.ToString("g"));
	Console.WriteLine(now.ToString("G"));
	Console.WriteLine(now.ToString("m"));
	Console.WriteLine(now.ToString("M"));
	Console.WriteLine(now.ToString("o"));
	Console.WriteLine(now.ToString("O"));
	Console.WriteLine(now.ToString("s"));
	Console.WriteLine(now.ToString("t"));
	Console.WriteLine(now.ToString("T"));
	Console.WriteLine(now.ToString("u"));
	Console.WriteLine(now.ToString("U"));
	Console.WriteLine(now.ToString("y"));
	Console.WriteLine(now.ToString("Y"));
            /*
             Output

d    2/27/2009
D    Friday, February 27, 2009
f    Friday, February 27, 2009 12:11 PM
F    Friday, February 27, 2009 12:12:22 PM
g    2/27/2009 12:12 PM
G    2/27/2009 12:12:22 PM
m    February 27
M    February 27
o    2009-02-27T12:12:22.1020000-08:00
O    2009-02-27T12:12:22.1020000-08:00
s    2009-02-27T12:12:22
t    12:12 PM
T    12:12:22 PM
u    2009-02-27 12:12:22Z
U    Friday, February 27, 2009 8:12:22 PM
y    February, 2009
Y    February, 2009
             */
        }
    }
}
