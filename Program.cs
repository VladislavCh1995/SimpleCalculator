using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            if (input == "+")
            {
                Console.WriteLine(a + b);
            }
            else if (input == "-")
            {
                Console.WriteLine(a - b);
            }
            else if (input == "*")
            {
                Console.WriteLine(a * b);
            }
            else if (input == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("На ноль делить нельзя!");
                }
                else
                {
                    Console.WriteLine((double)a / b);
                }
            }
            else
            {
                Console.WriteLine("Неверная операция");
            }
        }
    }
}
