namespace QuintaQuestao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string: ");
        string entrada = Console.ReadLine();
        if (string.IsNullOrEmpty(entrada))
        {
            Console.WriteLine("A string está vazia ou nula.");
            return;
        }
        string invertida = InverterString(entrada);
        Console.WriteLine($"String invertida: {invertida}");

        static string InverterString(string str)
        {
            char[] caracteres = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                caracteres[i] = str[str.Length - 1 - i];
            }
            return new string(caracteres);
        }
    }
}
