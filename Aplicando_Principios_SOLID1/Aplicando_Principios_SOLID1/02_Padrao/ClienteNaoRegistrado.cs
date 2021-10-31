namespace Aplicando_Principios_SOLID1
{
    public class ClienteNaoRegistrado : ICalculaDescontoStatusConta
    {
        public decimal AplicaDescontoStatusConta(decimal preco)
        {
            return preco;
        }
    }
}