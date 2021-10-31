namespace Aplicando_Principios_SOLID1
{
    public class ClienteComum : ICalculaDescontoStatusConta
    {
        public decimal AplicaDescontoStatusConta(decimal preco)
        {
            return preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco)
        }
    }
}