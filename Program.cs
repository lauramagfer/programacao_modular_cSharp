using System; 
// somando números
class Program
{
    public static void Main()
    {
        // declarando variáveis 
        int num1, num2, soma;

        // leitura do primeiro número
        Console.WriteLine("Digite um número: ");
        num1 = int.Parse(Console.ReadLine()!);

        // leitura do segundo número 
        Console.WriteLine("Digite outro número: ");
        num2 = int.Parse(Console.ReadLine()!);

        // soma
        soma = num1 + num2;

        // imprimindo na tela o resultado

        Console.WriteLine($"A soma solicitada foi de {soma}");
    }
}