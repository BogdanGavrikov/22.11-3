using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._11_практика_задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ведите возраст: ");
            string age = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"имя: {name}, возраст: {age}");
            Console.ReadKey();
        }
    }
}
