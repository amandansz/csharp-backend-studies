public class Fundamentos
{
    public static void Executar()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine() ?? "";
 
        Console.WriteLine($"Olá, {nome}!");

        Console.Write("Digite sua idade: ");
        string idade = Console.ReadLine() ?? "";
        Console.WriteLine($"Sua idade é: {idade}");

        if (int.Parse(idade) >= 18)
        {
            Console.WriteLine("Você é maior de idade, entrada liberada!");
        }
        else
        {
            Console.WriteLine("Você é menor de idade, entrada proibida!");
        }
    }
}