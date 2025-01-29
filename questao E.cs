using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("escolha um numero");
		int numero1 = int.Parse(Console.ReadLine());
		
		Console.WriteLine("escolha um outro numero");
		int numero2 = int.Parse(Console.ReadLine());

		
		int divisao = numero1 / numero2;
		
		
		Console.Write("a divisao dos seus numeros é :  " + divisao);
		Console.Write(Console.ReadLine());
		
		Console.WriteLine("aperte qualquer tecla para fechar");
		Console.ReadKey();
    
		
	}
}
