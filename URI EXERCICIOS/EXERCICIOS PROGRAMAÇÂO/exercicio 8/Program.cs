using System;
using System.Globalization;

namespace exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Double A, B, C, D, Difereca;

            A = Double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            B = Double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            C = Double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            D = Double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            Difereca = (A * B - C * D);
            Console.WriteLine("DIFERENCA = " + Difereca.ToString("F0", CultureInfo.InvariantCulture));

        }
    }
}