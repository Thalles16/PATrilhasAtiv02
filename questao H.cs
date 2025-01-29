using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha um número:");
        
        // Lê a entrada do usuário e converte para inteiro
        int numero = int.Parse(Console.ReadLine());

        // Calcula o valor absoluto
        double valorAbsoluto = Math.Abs(numero);

        // Exibe o resultado
        Console.WriteLine("O valor absoluto do número é: " + valorAbsoluto);
        
        Console.WriteLine("Aperte qualquer tecla para fechar.");
        Console.ReadKey();
    }
}
