using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Radius: ");
            double Radius = Double.Parse(Console.ReadLine());

            Circle c = new Circle (Radius);
            Console.WriteLine("Circuit is "  + c.Circuit());
            Console.WriteLine("Area of the circle is " + c.CircleArea());

            Console.ReadKey();

        }
    }
}
