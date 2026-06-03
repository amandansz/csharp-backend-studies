public class MultiplicationTable
{
  public static void Multiply()
    {
        Console.WriteLine("Bem vindo ao sistema de tabuada!/n"); 
        Console.WriteLine("Digite um número para ver a tabuada:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Tabuada do {number}:");

       for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}"); 
        }
    }
}