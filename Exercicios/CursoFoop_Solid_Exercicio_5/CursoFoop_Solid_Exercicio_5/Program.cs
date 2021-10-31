using System;

namespace CursoFoop_Solid_Exercicio_5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pizzaria p1 = new Pizzaria(new PizzaFactory());
            p1.CriarPizza("mussarela");
            p1.CriarPizza("calabresa");

            Console.ReadLine();
        }
    }
}