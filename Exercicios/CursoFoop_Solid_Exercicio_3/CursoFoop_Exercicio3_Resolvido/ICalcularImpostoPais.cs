namespace CursoFoop_Exercicio3_Resolvido
{
    public interface ICalcularImpostoPais
    {
        decimal TotalDeducao { get; set; }
        decimal TotalRenda { get; set; }

        decimal CalcularValorImposto();
    }
}