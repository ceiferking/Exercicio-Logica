using System;
using System.Globalization;

namespace EXERCICIO_11 
{
    class Program
    {
        static void Main(string[] args)
        {

            int X;
            double Y, Consumo;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Consumo = (double)X / Y;

            Console.WriteLine(Consumo.ToString("F3", CultureInfo.InvariantCulture) + " km/1");
        }
    }
}