using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            List<Person> personlist = new List<Person>();

            personlist.Add(new Person { Name = "Natalia", Age = 20, PhoneNumber = new string[] { "0930000000", "0670000000" } });
            personlist.Add(new Person { Name = "Ivan", Age = 45, PhoneNumber = new string[] { "0930000001", "0670000001", "0670000002" } });
            personlist.Add(new Person { Name = "Nazar", Age = 32, PhoneNumber = new string[] { "0930000002", "0670000003", "0930000003" } });
            personlist.Add(new Person { Name = "Halia", Age = 22, PhoneNumber = new string[] { "0930000004", "0930000005", "0670000004" } });
            personlist.Add(new Person { Name = "Igor", Age = 29, PhoneNumber = new string[] { "0670000005", "0670000006", "0670000007" } });
            personlist.Add(new Person { Name = "Liana", Age = 24, PhoneNumber = new string[] { "0930000006", "0930000007", "0930000008" } });

            foreach(var item in personlist)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }

            Console.ReadKey();
        }


        
    }
}
