using System;

namespace CursoFoop_Solid_Exercicio4
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Produto celularSamsung = new Celular(new PromocaoDiaMaes());
            celularSamsung.Nome = "Celular Samsung Galaxy S20";
            celularSamsung.Preco = 1000.00m;
            var precoCelular = celularSamsung.PrecoVenda();
            Console.WriteLine($"{celularSamsung.Nome} (20%OFF): {precoCelular}");

            Produto perfumeChanel = new Perfume(new PromocaoDiaNamorados());
            perfumeChanel.Nome = "Celular Samsung Galaxy S20";
            perfumeChanel.Preco = 500.00m;
            var precoPerfume = perfumeChanel.PrecoVenda();
            Console.WriteLine($"{perfumeChanel.Nome} (10%OFF): {precoPerfume}");

            Console.ReadLine();
        }
    }
}