using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число y:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число z:");
            int z = int.Parse(Console.ReadLine());
            if (y > x)
            {
                x = y;
            }
            else
            {

            }
            if (z > x)
            {
                x = z;
            }
            else
            {

            }
            Console.WriteLine(x);
        }


    }
}
