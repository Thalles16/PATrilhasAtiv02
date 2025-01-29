using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("escolha um numero");
		int numero1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("escolha um outro numero");
		int numero2 = int.Parse(Console.ReadLine());
		
		int soma = numero1 + numero2;
		
		
		Console.Write("A soma dos numeros é :  " + soma);
		Console.Write(Console.ReadLine());
		
		Console.WriteLine("aperte qualquer tecla para fechar");
		Console.ReadKey();
    
		
	}
}
