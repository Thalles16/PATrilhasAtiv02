using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("escolha um numero");
		int numero1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("escolha um outro numero");
		int numero2 = int.Parse(Console.ReadLine());
		
		int soma = numero2 - numero1;
		
		
		Console.Write("A divisao dos numeros é :  " + soma);
		Console.Write(Console.ReadLine());
		
		Console.WriteLine("aperte qualquer tecla para fechar");
		Console.ReadKey();
    
		
	}
}
