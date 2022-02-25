using System;
using System.Globalization;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, SOMA;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            SOMA = A + B;
            Console.WriteLine("SOMA = " + SOMA.ToString("F0", CultureInfo.InvariantCulture));

        }
    }
}