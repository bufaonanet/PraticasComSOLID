using Aplicando_Principios_SOLID1._02_Padrao.Interfces;

namespace Aplicando_Principios_SOLID1
{
    public class GerenciadorDeDesconto
    {
        private readonly ICalculaDescontoFidelidade _calculaDescontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory _calculaDescontoStatusContaFactory;

        public GerenciadorDeDesconto(
            ICalculaDescontoFidelidade calculaDescontoFidelidade,
            ICalculaDescontoStatusContaFactory calculaDescontoStatusContaFactory)
        {
            _calculaDescontoFidelidade = calculaDescontoFidelidade;
            _calculaDescontoStatusContaFactory = calculaDescontoStatusContaFactory;
        }

        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoDepoisDesconto = 0;

            precoDepoisDesconto = _calculaDescontoStatusContaFactory
                .GetCalculoDescontoStatusConta(statusContaCliente)
                .AplicaDescontoStatusConta(preco);

            precoDepoisDesconto = _calculaDescontoFidelidade
                .AplicaDescontoFidelidade(precoDepoisDesconto, tempoDeContaEmAnos);

            return precoDepoisDesconto;
        }
    }
}