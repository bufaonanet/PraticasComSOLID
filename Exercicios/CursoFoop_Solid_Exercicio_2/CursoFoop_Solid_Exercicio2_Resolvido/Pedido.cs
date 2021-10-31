using CursoFoop_Solid_Exercicio2_Resolvido;
using System;

namespace CursoFoop_Solid_Exercicio2
{
    public class Pedido
    {
        private readonly ILogger _log;

        public Pedido(ILogger log)
        {
            _log = log;
        }

        public virtual void AdicionarPedido()
        {
            try
            {
                //código para validar e incluir pedido
                _log.Registrar($"Pedido Incluido em :  {DateTime.Now}");
            }
            catch (Exception ex)
            {
                _log.Registrar($"{ex} - {DateTime.Now}");
            }
        }
    }
}