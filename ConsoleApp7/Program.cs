using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("введите месяц от <1-----12>");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите день от <1------31");
            int b = Convert.ToInt32(Console.ReadLine());
            DateTime date1 = new DateTime(2023, a, b);
            Console.WriteLine(date1);

        }
    }
}
