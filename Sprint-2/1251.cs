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
			string entrada;
			List<string> listaFinal = new List<string>();

			while (!string.IsNullOrEmpty(entrada = Console.ReadLine()))
			{
				var letras = Encoding.ASCII.GetBytes(entrada);
				var grupo = letras.GroupBy(x => x, (source, element) => new
				{
					Key = source,
					Count = element.Count()
				});

				grupo = grupo.OrderBy(x => x.Count).ThenByDescending(x => x.Key).ToList();

				if (listaFinal.Any()) listaFinal.Add("");

				foreach (var letra in grupo)
					listaFinal.Add(letra.Key + " " + letra.Count);
			}

			listaFinal.ForEach(x => Console.WriteLine(x));

		}
	}
}
