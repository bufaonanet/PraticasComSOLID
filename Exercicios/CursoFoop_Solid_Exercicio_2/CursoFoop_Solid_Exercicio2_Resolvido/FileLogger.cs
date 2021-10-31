using CursoFoop_Solid_Exercicio2_Resolvido;
using System.IO;

namespace CursoFoop_Solid_Exercicio2
{
    public class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            const string caminho = @"C:\MyDev\TesteLog.txt";

            File.WriteAllText(caminho, mensagem);
        }
    }
}