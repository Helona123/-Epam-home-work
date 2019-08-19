using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Rectangle : Figure
    {

        public Rectangle() : base(0, 0) { }

        public override void Draw()
        {
            Console.WriteLine("I am rectangle");
        }
    }
}
