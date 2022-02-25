using System;
using System.Globalization;

namespace EXERCICIO_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalKm;
            int Temp;
            int Km = 2;

            Temp = int.Parse(Console.ReadLine());

            totalKm = Km * Temp;

            Console.WriteLine(totalKm.ToString("F0",  CultureInfo.InvariantCulture ) + " minutos");

        }
    }
}