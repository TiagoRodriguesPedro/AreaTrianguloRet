using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            double medidaBase, medidaAltura, medidaArea;
            Console.Write("Qual é a base..:");
            medidaBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Qual é a Altura..:");
            medidaAltura = Convert.ToDouble(Console.ReadLine());

            medidaArea =(medidaBase * medidaAltura) /2;

            Console.WriteLine($"Areadotriangulo: {medidaArea}");

        }
    }
}
