using System;
using System.Collections.Generic;

namespace QuartaQuestao;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, double> faturamentoPorEstado = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }            
        };

        double faturamentoTotal = 0;
        foreach (var valor in faturamentoPorEstado.Values)
        {
            // Converte o valor de string para double
            faturamentoTotal += valor;
        }
        Console.WriteLine($"Faturamento total: {faturamentoTotal}");
        Console.WriteLine("Percentual de representação de cada estado no faturamento total:");
        foreach (var estado in faturamentoPorEstado)
        {
            double percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}
