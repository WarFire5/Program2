using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string clientFirstName;
            string clientLastName;
            string clientLastSecondName;

            Console.WriteLine("Как Вас зовут?");
            clientFirstName = Console.ReadLine();

            Console.WriteLine("Какая у Вас фамилия?");
            clientLastName = Console.ReadLine();

            Console.WriteLine("Как Ваше отчество?");
            clientLastSecondName = Console.ReadLine();

            string clientAllName = clientFirstName + " " + clientLastName + " " + clientLastSecondName;
            Console.WriteLine(clientAllName);

            Console.ReadLine();
        }
    }
}
