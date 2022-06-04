using System;
using System.Globalization;
using System.IO;

namespace sprint
{
    class Program
    {
        static void Main(string[] args)
        {
            string entradaTexto;
            while ((entradaTexto = Console.ReadLine()) != null)
            {
                var arrayTexto = entradaTexto.ToCharArray();
                var ultimaMaiuscula = false;

                var resultadoTexto = "";

                for (int i = 0; i < arrayTexto.Length; i++)
                {
                    if (!char.IsWhiteSpace(arrayTexto[i]))
                    {
                        resultadoTexto += ultimaMaiuscula ? char.ToLower(arrayTexto[i]) : char.ToUpper(arrayTexto[i]);
                        ultimaMaiuscula = !ultimaMaiuscula;
                    }
                    else
                        resultadoTexto += arrayTexto[i];
                }

                Console.WriteLine(resultadoTexto);
            }
        }
    }
}
