using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Rectangle
    {
        private int height;
        private int width;
        public double perimeter
        {
            get { return perimeter = (width + height) * 2; }
            set { }
        }

        public double squere
        { get { return squere = width * height; } 
          set { }
        }


        public Rectangle(List<int> PointA, List<int> PointC)
        {
            this.width = PointA[0] - PointC[0];
            this.height = PointA[1] - PointC[1];

        }

      /*  private void Perimeter()
        {
             perimeter = (width + height) * 2;
        }*/

      /*  private void Squere()
        {
             squere = width * height;
        }*/
    }
}
