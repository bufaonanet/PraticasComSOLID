using System;

namespace OCP_Violacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido valorPedidoClienteComun = new PedidoClienteComun();
            Pedido valorPedidoClienteAssociado = new PedidoClienteAssociado();
            Pedido valorPedidoClienteEspecial = new PedidoClienteEspecial();         

            Console.WriteLine("Principio OCP - Violação");

            Console.WriteLine($"Cliente Comum = " +
                $"{valorPedidoClienteComun.DescontoPedido(100)}");

            Console.WriteLine($"Cliente Associado = " +
                $"{valorPedidoClienteAssociado.DescontoPedido(100)}");

            Console.WriteLine($"Cliente Especial = " +
                $" {valorPedidoClienteEspecial.DescontoPedido(100)}");

            Console.ReadLine();
        }
    }
}
