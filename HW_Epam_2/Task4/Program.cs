﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            Square squere = new Square();
            Figure figure = new Figure();

            rect.Draw();
            squere.Draw();

            figure.Draw();

            Console.ReadKey();
        }
    }
}
