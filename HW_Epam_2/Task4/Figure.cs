using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Figure: IDrawable
    {
        readonly int X;
        readonly int Y;
        public Figure() { }

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
