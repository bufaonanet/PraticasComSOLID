namespace OCP_Violacao
{
    class PedidoClienteAssociado : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal - 10;
        }

    }
}
