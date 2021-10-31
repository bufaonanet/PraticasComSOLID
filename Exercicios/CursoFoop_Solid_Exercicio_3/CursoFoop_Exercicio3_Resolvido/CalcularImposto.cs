namespace CursoFoop_Exercicio3_Resolvido
{
    static class CalcularImposto
    {
        public static decimal Calcular(ICalcularImpostoPais icalc)
        {
            return icalc.CalcularValorImposto();
        }
    }
}