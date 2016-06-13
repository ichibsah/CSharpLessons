using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_Why_Properties
{
<<<<<<< HEAD
=======
    public class Student
    {
        private int _id;
        private string _Name;
        private int _PassMark = 35;

        public void SetId(int Id)
        {
            if (Id <= 0)
            {
                throw new Exception("cannot lah");
            }
            this._id = Id;
        }

        public int GetId()
        {
            return this._id;
        }
    }

>>>>>>> 0dc5801c9bb1ac7f99ccf7ff2f8efdf9834dc1d0
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
=======
            Student C1 = new Student();
            /*this will work if fields were not private*/
            //C1.id = -101;
            /*throw an error*/
            C1.SetId(-101);
                        
            Console.WriteLine("asd {0}",C1.GetId());
>>>>>>> 0dc5801c9bb1ac7f99ccf7ff2f8efdf9834dc1d0
        }
    }
}
