using System;
using System.Globalization;

namespace EXERCICIO_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Funcionarios, Horas, Shora, SalarioTotal;

            Funcionarios = Double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            Horas = Double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            Shora = Double.Parse(Console.ReadLine(), (CultureInfo.InvariantCulture));
            SalarioTotal = Horas * Shora;

            Console.WriteLine("NUMBER = " + Funcionarios.ToString("F0", CultureInfo.InvariantCulture));
            Console.WriteLine("SALARY = U$ " + SalarioTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}