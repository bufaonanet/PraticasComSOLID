using cursoFoop_Exercicio_SOLID1;
using System.Collections.Generic;
using System.Text;

namespace cursoFoop_Exercicio_SOLID1_Resolvido
{
    public static class ExportarDados
    {
        public static string ExportarCSV(List<Cliente> dados)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in dados)
            {
                sb.AppendFormat($"{item.Nome},{item.Pais},{item.Email}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}