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
            List<Person> personList = new List<Person>();

            personList.Add(new Person { Name = "Natalia", Age = 20, PhoneNumber = new string[] { "0930000000", "0670000000" } });
            personList.Add(new Person { Name = "Ivan", Age = 45, PhoneNumber = new string[] { "0930000001", "0670000001", "0670000002" } });
            personList.Add(new Person { Name = "Nazar", Age = 32, PhoneNumber = new string[] { "0930000002", "0670000003", "0930000003" } });
            personList.Add(new Person { Name = "Halia", Age = 22, PhoneNumber = new string[] { "0930000004", "0930000005", "0670000004" } });
            personList.Add(new Person { Name = "Igor", Age = 29, PhoneNumber = new string[] { "0670000005", "0670000006", "0670000007" } });
            personList.Add(new Person { Name = "Liana", Age = 24, PhoneNumber = new string[] { "0930000006", "0930000007", "0930000008" } });

          /*  foreach (var item in personList)
                Console.WriteLine(item.Name + " " + item.Age);*/

            Person[] arrPerson = new Person[2] { new Person { Name = "Khristina", Age = 32, PhoneNumber = new string[] { "0670000008", "0670000012", "0670000026" } },
                                                 new Person { Name = "Andriy", Age = 33, PhoneNumber = new string[]{"0930000023","0930000043","0930000064"} } };

            personList.AddRange(arrPerson);

            foreach (var person in personList)
            {
                Console.WriteLine(person.Name + " " + person.Age);
               
                foreach (var personPhone in person.PhoneNumber)
                    Console.WriteLine(personPhone);
            }
            Console.ReadKey(); 
            
        }
    }
}
