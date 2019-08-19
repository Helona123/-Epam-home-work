using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter first complex number (a and b)");
            var number1 = new ComplexNumber {A = Int32.Parse(Console.ReadLine()), B = Int32.Parse(Console.ReadLine())};

            Console.WriteLine("Enter second complex number (a and b)");
            var number2 = new ComplexNumber {A = Int32.Parse(Console.ReadLine()), B = Int32.Parse(Console.ReadLine())};

            ComplexNumber multNumber = number1 * number2;
            ComplexNumber divNumber = number1 / number2;

            Console.WriteLine("Multiplication of complex number is : " + multNumber.A + " + " + multNumber.B + "i");
            Console.WriteLine("Division of complex number is : " + divNumber.A + " + " + divNumber.B + "i");

            Console.ReadKey();
        }
    }
}
