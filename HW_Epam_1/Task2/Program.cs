using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var PointA = new List<string>();
            var PointC = new List<string>();

            Rectangle rect;

            Console.Write("Enter the point A :");
            PointA.AddRange(Console.ReadLine().Split(' '));

            Console.Write("Enter the point C:");
            PointC.AddRange(Console.ReadLine().Split(' '));

            rect = new Rectangle(PointA.Select(int.Parse).ToList(), PointC.Select(int.Parse).ToList());

            Console.WriteLine("Rectangle perimeter = " + rect.perimeter);
            Console.WriteLine("Rectangle sqere = " + rect.squere);
            

            Console.ReadKey();
        }
    }
}
