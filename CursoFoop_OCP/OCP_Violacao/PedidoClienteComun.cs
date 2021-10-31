namespace OCP_Violacao
{
    class PedidoClienteComun : Pedido
    {
        public override double DescontoPedido(double valorFinal)
        {
            return valorFinal -5;
        }


    }
}
