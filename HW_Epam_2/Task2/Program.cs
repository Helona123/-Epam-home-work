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
            Rectangle rect = new Rectangle();
            Square squere = new Square();
            rect.Draw();
            squere.Draw();

            Console.ReadKey();
        }
    }
}
