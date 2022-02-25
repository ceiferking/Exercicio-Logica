using System;
using System.Globalization;

namespace EXERCICIO_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Double A, B, C, MEDIA, SOMA, Pa, Pb, Pc, PT, Ma, Mb, Mc;
            Pa = 2f;
            Pb = 3f;
            Pc = 5f;
            PT = 10f;

            A = Double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            B = Double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            C = Double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            Ma = A * Pa;
            Mb = B * Pb;
            Mc = C * Pc;
            SOMA = Mb + Ma + Mc;
            MEDIA = (SOMA / PT);

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}