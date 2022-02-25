using System;
using System.Globalization;

namespace EXERCICIO_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int Temp, Velocidade;
            float KmT, Lt;
            int Lkm = 12;
            
            Temp = int.Parse(Console.ReadLine());
            Velocidade = int.Parse(Console.ReadLine());

            KmT = Temp * Velocidade;
            Lt = KmT / Lkm;

            Console.WriteLine(Lt.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}