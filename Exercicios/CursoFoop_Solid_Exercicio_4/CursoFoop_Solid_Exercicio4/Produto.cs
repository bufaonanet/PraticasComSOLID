namespace CursoFoop_Solid_Exercicio4
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        protected IPromocao _promocao;

        protected Produto(IPromocao promocao)
        {
            _promocao = promocao;
        }

        public decimal DescontoPromocao()
        {
            return _promocao.Desconto();
        }

        public decimal PrecoVenda()
        {
            return Preco - (Preco * DescontoPromocao());
        }
    }
}