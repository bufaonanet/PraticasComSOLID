namespace Aplicando_Principios_SOLID1
{
    public class CalculaDescontoFidelidade : ICalculaDescontoFidelidade
    {
        public decimal AplicaDescontoFidelidade(decimal preco, int tempoDeContaEmAnos)
        {
            decimal descontoPorFinalidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ?
                (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 : (decimal)tempoDeContaEmAnos / 100;

            return preco - (descontoPorFinalidade * preco);
        }
    }
}