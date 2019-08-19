using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Epam_1
{
    class Rectangle
    {

        private int height;
        private int width;


        public Rectangle(List<int>PointA, List<int> PointC)
        {
            width = PointA[0] - PointC[0];
            height = PointA[1] - PointC[1];

        }

        public void Perimeter()
        { 
            double perimeter = (width + height) * 2;
            Console.WriteLine("Rectangle perimeter = " + perimeter);
        }

        public void Squere ()
        {
            double squere = width * height;
            Console.WriteLine("Rectangle squere = " + squere);
        }
        


        


    }
}
