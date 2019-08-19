using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    static class Rectangle
    {
       private static int width;
       private static int height;


        public static void Perimeter(List<int> PointA, List<int> PointC)
        {

            width = PointA[0] - PointC[0];
            height = PointA[1] - PointC[1];
            Console.WriteLine("Rectangle perimeter = " + (width + height) * 2);
        }

        public static void Squere(List<int> PointA, List<int> PointC)
        {
            width = PointA[0] - PointC[0];
            height = PointA[1] - PointC[1];
            Console.WriteLine("Rectangle sqere = " + width * height);
        }
    }
}

