namespace CursoFoop_Solid_Exercicio_5
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela(string nome) : base(nome)
        {
        }

        public override int TempoAssarPizza()
        {
            var tempo = 25;
            System.Console.WriteLine($"Assando pizza de {Nome} por {tempo} minutos");
            return tempo;
        }
    }
}