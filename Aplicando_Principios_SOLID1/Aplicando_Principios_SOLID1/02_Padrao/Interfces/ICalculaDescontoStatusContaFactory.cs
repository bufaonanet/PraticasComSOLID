namespace Aplicando_Principios_SOLID1._02_Padrao.Interfces
{
    public interface ICalculaDescontoStatusContaFactory
    {
        ICalculaDescontoStatusConta GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente);
    }
}