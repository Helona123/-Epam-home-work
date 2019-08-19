using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            var PointA = new List<string>();
            var PointC = new List<string>();

          
            Console.Write("Enter the point A : ");
            PointA.AddRange(Console.ReadLine().Split(' '));

            Console.Write("Enter the point C: ");
            PointC.AddRange(Console.ReadLine().Split(' '));

           
            Rectangle.Perimeter(PointA.Select(int.Parse).ToList(), PointC.Select(int.Parse).ToList());
            Rectangle.Squere(PointA.Select(int.Parse).ToList(), PointC.Select(int.Parse).ToList());

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.Write("Enter Radius: ");
            double Radius = Double.Parse(Console.ReadLine());
            
            Console.WriteLine("Circuit is " + Circle.Circuit(Radius));
            Console.WriteLine("Area of the circle is " + Circle.CircleArea(Radius));

            Console.ReadKey();
        }

    }
}
