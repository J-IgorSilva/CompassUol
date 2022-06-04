using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sprint
{
    class Program
    {
        static void Main(string[] args)
        {
			var testeNumeros = int.Parse(Console.ReadLine());
			var Par = new List<int>();
			var Impar = new List<int>();

			for (int n = 0; n < testeNumeros; n++)
			{
				var numero = int.Parse(Console.ReadLine());
				if (numero % 2 == 0)
					Par.Add(numero);
				else
					Impar.Add(numero);
			}

			Par = Par.OrderBy(x => x).ToList();
			Impar = Impar.OrderByDescending(x => x).ToList();

			Par.ForEach(x => Console.WriteLine((x)));
			Impar.ForEach(x => Console.WriteLine((x)));
		}
	}
}
