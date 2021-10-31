using System;

namespace CursoFoop_Exercicio3_Resolvido
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            ICalcularImpostoPais calc = new CalcularImpostoBrazil();
            calc.TotalRenda = 1000;
            calc.TotalDeducao = 100;

            var valorTotalImposto = CalcularImposto.Calcular(calc);

            Console.WriteLine($"Total do imposto de  {valorTotalImposto}");
            Console.ReadLine();
        }
    }
}