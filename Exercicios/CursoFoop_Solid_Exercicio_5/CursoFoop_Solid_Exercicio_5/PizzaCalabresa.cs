using System;

namespace CursoFoop_Solid_Exercicio_5
{
    internal class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa(string nome) : base(nome)
        {
        }

        public override int TempoAssarPizza()
        {
            var tempo = 30;
            Console.WriteLine($"Assando pizza de {Nome} por {tempo} minutos");
            return tempo;
        }
    }
}