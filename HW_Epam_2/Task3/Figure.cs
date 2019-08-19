using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
        public class Figure
        {
            readonly int X;
            readonly int Y;

            public Figure(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public virtual void Draw()
            {
                Console.WriteLine("I am figure");
            }
        }
    
}
