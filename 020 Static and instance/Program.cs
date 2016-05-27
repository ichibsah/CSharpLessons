using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_Static_and_instance
{
    class Circle
    {
        /*a static member*/
        static float _PI;
        int _Radius;

        /*static constructors does not allow access modifire and it cant be called. 
         * they are called automatically even before instance constructors.
         mostly used to inicialize static fields in a class.*/
        static Circle()
        {
            Circle._PI = 3.141F;
        }
        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public static void Print()
        {
            //Console.WriteLine("Area = {0}", Area2;
        }

        public float CalculareArea()
        {
            /*call static members with class name, not with instance name or (Circle._PI)*/
            return _PI * this._Radius * this._Radius;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area = C1.CalculareArea();

            Console.WriteLine("Area = {0}", Area);

            Circle C2 = new Circle(6);
            float Area2 = C2.CalculareArea();
            /*call static members with class name, not with instance name*/
            Circle.Print();
            Console.WriteLine("Area = {0}", Area2);
        }
    }
}
