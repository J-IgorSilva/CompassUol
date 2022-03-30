using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace sprint
{
    class Program
    {
        static void Main(string[] args)
        {
			var testeNumeros = int.Parse(Console.ReadLine());
			var lordemDaLinha = new List<string>();

			for (int n = 0; n < testeNumeros; n++)
			{
				var linha = Console.ReadLine().Split(' ').ToList();
				linha = linha.OrderByDescending(x => x.Length).ToList();
				lordemDaLinha.Add(string.Join(" ", linha.ToArray())); // metodo para concatenar e ordenar
			}

			lordemDaLinha.ForEach(x => Console.WriteLine((x))); // comando para cada elemento lista
			
		}
	}
}
