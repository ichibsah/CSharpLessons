using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {/*List has methods that search for and change data. It is ideal for elements accessed by indexes. It is an optimized ArrayList.*/
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(7);

            foreach (int prime in list) // Loop through List with foreach.
            {
                Console.WriteLine(prime);
            }

            for (int i = 0; i < list.Count; i++) // Loop with for.
            {
                Console.WriteLine(list[i]);
            }

            /*clear*/
            List<bool> list = new List<bool>();
            list.Add(true);
            list.Add(false);
            list.Add(true);
            Console.WriteLine(list.Count); // 3

            list.Clear();
            Console.WriteLine(list.Count); // 0

            /*copies array to List*/

            int[] arr = new int[3]; // New array with 3 elements.
            arr[0] = 2;
            arr[1] = 3;
            arr[2] = 5;
            List<int> list = new List<int>(arr); // Copy to List.
            Console.WriteLine(list.Count);       // 3 elements in List.

            /*that uses IndexOf*/

            List<int> primes = new List<int>(new int[] { 19, 23, 29 });

            int index = primes.IndexOf(23); // Exists.
            Console.WriteLine(index);

            index = primes.IndexOf(10); // Does not exist.
            Console.WriteLine(index);

            /*joins List*/
            // List of cities we need to join.
            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("Mumbai");
            cities.Add("Berlin");
            cities.Add("Istanbul");

            // Join strings into one CSV line.
            string line = string.Join(",", cities.ToArray());
            Console.WriteLine(line);

            /*that converts Keys*/

            // Populate example Dictionary.
            var dict = new Dictionary<int, bool>();
            dict.Add(3, true);
            dict.Add(5, false);

            // Get a List of all the Keys.
            List<int> keys = new List<int>(dict.Keys);
            foreach (int key in keys)
            {
                Console.WriteLine(key);
            }

            /*inserts into List*/

            List<string> dogs = new List<string>(); // Example list.

            dogs.Add("spaniel"); // Contains: spaniel.
            dogs.Add("beagle"); // Contains: spaniel, beagle.
            dogs.Insert(1, "dalmatian"); // Spaniel, dalmatian, beagle.

            foreach (string dog in dogs) // Display for verification.
            {
                Console.WriteLine(dog);
            }

            /*uses Reverse*/

            List<string> list = new List<string>();
            list.Add("anchovy");
            list.Add("barracuda");
            list.Add("bass");
            list.Add("viperfish");

            // Reverse List in-place, no new variables required.
            list.Reverse();

            foreach (string value in list)
            {
                Console.WriteLine(value);
            }

            /*gets ranges from List*/
            List<string> rivers = new List<string>(new string[]
	{
	    "nile",
	    "amazon", // River 2.
	    "yangtze", // River 3.
	    "mississippi",
	    "yellow"
	});

            // Get rivers 2 through 3.
            List<string> range = rivers.GetRange(1, 2);
            foreach (string river in range)
            {
                Console.WriteLine(river);
            }

            /*uses var with List*/

            var list1 = new List<int>();       // Var keyword used.
            List<int> list2 = new List<int>(); // This is equivalent.

            /*that uses GetEnumerator*/

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(5);
            list.Add(9);

            List<int>.Enumerator e = list.GetEnumerator();
            Write(e);
        }

        static void Write(IEnumerator<int> e)
        {
            while (e.MoveNext())
            {
                int value = e.Current;
                Console.WriteLine(value);
            }
        }

        /**/
    }
}

