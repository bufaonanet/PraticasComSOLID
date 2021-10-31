﻿using CursoFoop_Solid_Exercicio2;
using System;

namespace CursoFoop_Solid_Exercicio2_Resolvido
{
    static class Program
    {
        static void Main(string[] args)
        {

            ILogger meuLogArquivo = new FileLogger();
            ILogger meuLogConsole = new ConsoleLogger();

            Pedido pedido = new Pedido(meuLogConsole);
            pedido.AdicionarPedido();
            Console.ReadLine();

        }
    }
}
