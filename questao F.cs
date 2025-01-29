using System;
	
	class program 
{
	static void Main ()
	{ 
		Console.WriteLine("escolha um numero");
		int numero1 = int.Parse(Console.ReadLine());
		
		double raizQuadrada = Math.Sqrt(numero1);
		
		
		Console.Write("a raiz quadrada dos seus numeros é :  " + raizQuadrada);
		Console.Write(Console.ReadLine());
		
		Console.WriteLine("aperte qualquer tecla para fechar");
		Console.ReadKey();
    
		
	}
}
