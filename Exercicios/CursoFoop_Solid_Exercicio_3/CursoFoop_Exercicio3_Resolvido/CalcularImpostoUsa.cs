﻿namespace CursoFoop_Exercicio3_Resolvido
{
    public class CalcularImpostoUsa : ICalcularImpostoPais
    {
        public decimal TotalDeducao { get; set; }
        public decimal TotalRenda { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 30 / 100;
        }
    }
}