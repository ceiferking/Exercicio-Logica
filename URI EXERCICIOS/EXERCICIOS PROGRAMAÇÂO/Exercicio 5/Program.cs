using System;
using System.Globalization;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double X, Y, PROD;

            X = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            Y = double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            PROD = X * Y;
            Console.WriteLine("PROD = " + PROD.ToString(CultureInfo.InvariantCulture));

        }
    }
}