using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа:");
            string a, b;
            a = Console.ReadLine();
            b = Console.ReadLine();
            int sum = int.Parse(a)+int.Parse(b);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
