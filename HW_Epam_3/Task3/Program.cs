using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var listWords = new List<string>();
            //var TestList = new List<string>() {"ZZSD","ZSCF","FRNG","ZDVR","FRNG","DDSS" };
            PagesList pagelist = new PagesList { N = 800, WordLenght = 4 };

            listWords = pagelist.CreateList(listWords);
            Console.WriteLine("Number of items before changes : " + listWords.Count);

            listWords = pagelist.TransformerList(listWords);
            Console.WriteLine("Number of items after changes : " + listWords.Count);

            listWords.Sort();
            listWords.Reverse();

            try
            {
                Console.Write("Enter the number of page (1 - " + listWords.Count / 5 + " )");
                pagelist.DisplayPage(Int32.Parse(Console.ReadLine()), listWords);
            }
            catch (FormatException)
            {
                Environment.Exit(0);
            }

            Console.ReadKey();

        }
    }
}
