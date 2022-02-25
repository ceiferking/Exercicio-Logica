using System;
using System.Globalization;

namespace EXERCICIO_TEOREMA_TRIANGULO
{
    class Program
    {
        static void Main(string[] args)
        {
            double B, A, Area, Perimetro, Diagonal;

            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = B * A;
            Perimetro = 2 * (B + A);
            Diagonal = Math.Sqrt(Math.Pow(B, 2.0) + Math.Pow(A, 2.0));

            Console.WriteLine("AREA = " + Area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + Perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + Diagonal.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
