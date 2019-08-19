using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Epam_1
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

            rect.Perimeter();
            rect.Squere();

            Console.ReadKey();
        }
    }
}
