using System;
using System.Globalization;
using System.IO;

namespace sprint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valorEntrada = Console.ReadLine().Split(' ');

            int A = int.Parse(valorEntrada[0]);

            int B = int.Parse(valorEntrada[1]);

            int C = int.Parse(valorEntrada[2]);

            int maiorAB = ((A + B + Math.Abs(A - B)) / 2); 

            Console.WriteLine(((maiorAB + C + Math.Abs(maiorAB - C)) / 2) + " eh o maior");

        }
    }
}
