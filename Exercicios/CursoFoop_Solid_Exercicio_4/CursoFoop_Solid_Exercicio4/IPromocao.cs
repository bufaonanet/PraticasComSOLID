namespace CursoFoop_Solid_Exercicio4
{
    public interface IPromocao
    {
        decimal Desconto();
    }

    public class PromocaoDiaMaes : IPromocao
    {
        public decimal Desconto()
        {
            return 0.10m;
        }
    }

    public class PromocaoDiaNamorados : IPromocao
    {
        public decimal Desconto()
        {
            return 0.20m;
        }
    }
}