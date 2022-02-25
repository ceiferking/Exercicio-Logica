using System;
using System.Globalization;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Largura, Comprimento, PrecoMetroQuadrado, Area, Preco;

            Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            PrecoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = Largura * Comprimento;
            Preco = Area * PrecoMetroQuadrado;

            Console.WriteLine("AREA = " + Area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + Preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }

    }
}
