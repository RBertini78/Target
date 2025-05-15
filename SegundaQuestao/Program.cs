namespace SegundaQuestao;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if(PertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

static bool PertenceFibonacci(int numero)
{
    int a = 0;
    int b = 1;
    int c = 0;

    if (numero == a || numero == b)
    {
        return true;
    }

    while (c < numero)
    {
        c = a + b;
        a = b;
        b = c;

        if (c == numero)
        {
            return true;
        }
    }

    return false;
}
}