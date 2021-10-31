namespace OCP_Violacao
{    
    public abstract class Pedido
    {
        //...outro codigo
        public virtual double DescontoPedido(double valorFinal)
        {
            return valorFinal;
        }
    }
}