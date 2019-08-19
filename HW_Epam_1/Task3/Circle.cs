using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Circle
    {
        private double radius;
        private const double pi = 3.14;

        public Circle (double R)
        {
            this.radius = R;
        }

     

        public double Circuit ()
        {
           return    2 * pi * radius;
        }
        public double CircleArea()
        {
           return  pi * (radius * radius);
        }

    }

}
