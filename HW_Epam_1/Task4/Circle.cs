using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
   static  class Circle
    {
        private  const double pi = 3.14;

       
        public static  double Circuit( double radius)
        {
            return 2 * pi * radius;
        }
        public static double CircleArea(double radius)
        {
            return pi * (radius * radius);
        }

    }
}
