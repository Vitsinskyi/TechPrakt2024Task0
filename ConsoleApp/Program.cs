using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("перше число:");
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("некоректний формат числа!");
                return;
            }

            Console.WriteLine("друге число:");
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("некоректний формат числа!");
                return;
            }

            int sum = number1 + number2;
            Console.WriteLine($"нума чисел дорiвнює: {sum}");
        }
    }
}
