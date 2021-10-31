using System;

namespace CursoFoop_Solid_Exercicio_5
{
    public abstract class Pizza
    {
        public string Nome { get; set; }

        protected Pizza(string nome)
        {
            Nome = nome;
        }

        public void EntregarPizza()
        {
            Console.WriteLine($"Entregar Pizza de {Nome}");
        }

        public abstract int TempoAssarPizza();
    }
}