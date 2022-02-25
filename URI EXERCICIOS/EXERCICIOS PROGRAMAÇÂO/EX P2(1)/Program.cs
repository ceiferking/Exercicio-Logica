using System;
using System.Globalization;

namespace EX_P2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendedor;
            double saladrioT, extra, Total, vendas;



            vendedor = Console.ReadLine();
            saladrioT = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            extra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vendas = extra * 0.15;
            Total = vendas + saladrioT;

            Console.WriteLine("TOTAL = " + Total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
