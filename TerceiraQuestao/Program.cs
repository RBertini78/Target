using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;    

namespace TerceiraQuestao;

class Faturamento
{
    public string Dia { get; set; }
    public double Valor { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        string json = File.ReadAllText("dados.json");
        List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(json);

        var faturamentosValidos = faturamentos.Where(f => f.Valor > 0).ToList();

        if (faturamentosValidos.Count == 0)
        {
            Console.WriteLine("Não há faturamentos válidos.");
            return;
        }

        double menorFaturamento = faturamentosValidos.Min(f => f.Valor);
        double maiorFaturamento = faturamentosValidos.Max(f => f.Valor);
        double mediaMensal = faturamentosValidos.Average(f => f.Valor);
        int diasAcimaMedia = faturamentosValidos.Count(f => f.Valor > mediaMensal);

        Console.WriteLine($"Menor Faturamento: {menorFaturamento:F2}");
        Console.WriteLine($"Maior Faturamento: {maiorFaturamento:F2}");
        Console.WriteLine($"Média Mensal: {mediaMensal:F2}");
        Console.WriteLine($"Dias com Faturamento Acima da Média: {diasAcimaMedia}");
    }
}
