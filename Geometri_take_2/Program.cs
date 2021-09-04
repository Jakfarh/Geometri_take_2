using System;

namespace Geometri_take_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic Square1 = new Logic();
            Square1.Side_A = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(Square1.Perimeter());
            Console.WriteLine();
            Console.WriteLine(Square1.area());
        }

    }
}
