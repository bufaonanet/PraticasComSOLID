using System;

namespace Aplicando_Principios_SOLID1._02_Padrao.Interfces
{
    internal class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente)
        {
            ICalculaDescontoStatusConta calcular;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    calcular = new ClienteNaoRegistrado();
                    break;

                case StatusContaCliente.ClienteComum:
                    calcular = new ClienteComum();
                    break;

                case StatusContaCliente.ClienteEspecial:
                    calcular = new ClienteEspecial();
                    break;

                case StatusContaCliente.ClienteVip:
                    calcular = new ClienteVip();
                    break;

                default:
                    throw new NotImplementedException();
            }
            return calcular;
        }
    }
}