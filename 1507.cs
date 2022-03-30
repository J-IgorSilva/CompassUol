using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sprint
{
    static class Program
    {
        static void Main(string[] args)
        {
			var n = int.Parse(Console.ReadLine());
			var resultadoFinal = new List<string>();

			for (int i = 0; i < n; i++)
			{
				var entradaDeS = Console.ReadLine();

				var q = int.Parse(Console.ReadLine());
				var entradasDeR = new List<string>();

				for (int y = 0; y < q; y++)
				{
					var entradaDeR = Console.ReadLine();
					entradasDeR.Add(entradaDeR);
				}

				foreach (var verific in entradasDeR)
				{
					if (entradaDeS.VerificarSubsequencia(verific))
						resultadoFinal.Add("Yes");
					else
						resultadoFinal.Add("No");
				}
			}

			resultadoFinal.ForEach(x => Console.WriteLine(x));
		}

		private static bool VerificarSubsequencia(this string entrada, string consulta)
		{
			var consultaIndex = 0;
			for (var entradaIndex = 0; entradaIndex < entrada.Length; entradaIndex++)
			{
				if (consulta[consultaIndex] == entrada[entradaIndex])
					consultaIndex++;

				if (consultaIndex == consulta.Length)
					return true;
			}

			return false;
		}
	}
}
