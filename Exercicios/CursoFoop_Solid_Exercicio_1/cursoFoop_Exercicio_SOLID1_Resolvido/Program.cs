using cursoFoop_Exercicio_SOLID1;
using System;

namespace cursoFoop_Exercicio_SOLID1_Resolvido
{
    static class Program
    {
        static void Main(string[] args)
        {
            var cliente = LocalizaCliente.ProcuraPorNome("Pedro2");
            
            Console.WriteLine(cliente?.Nome ?? "Não localizado");
            Console.ReadLine();
        }
    }
}
