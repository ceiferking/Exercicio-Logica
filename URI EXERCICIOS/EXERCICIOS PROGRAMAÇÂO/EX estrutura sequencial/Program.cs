using System;
using System.Globalization;

namespace EX_estrutura_sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;
            string Nome1, Nome2;
            double Media;

            string[] vet;

            vet = Console.ReadLine().Split(" ");
            Nome1 = vet[0];
            idade1 = int.Parse(vet[1]);
            vet = Console.ReadLine().Split(" ");
            Nome2 = vet[0];
            idade2 = int.Parse(vet[1]);

            Media = (idade1 + idade2) / 2.0;

            Console.WriteLine("Idade media de " + Nome1 + " e " + Nome2 + " é de " + Media.ToString("F1", CultureInfo.InvariantCulture) + " anos");

        }
    }
}
