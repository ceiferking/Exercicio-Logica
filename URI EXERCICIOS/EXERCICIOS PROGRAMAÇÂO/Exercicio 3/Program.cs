using System;
using System.Globalization;

namespace Exercicio_3
{
    class Program
    {

        static void Main(string[] args)
        {

            double A, N, R, Rfinal;

            N = 3.14159;
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Rfinal = Math.Pow(R, 2.0);
            A = N * Rfinal;
            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
