using System;
using System.Globalization;
using System.IO;

namespace sprint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] onelinha = Console.ReadLine().Split(' ');

            int produto1 = Convert.ToInt32(onelinha[0]);

            int unidades1 = Convert.ToInt32(onelinha[1]);

            decimal preco1 = Convert.ToDecimal(onelinha[2]);

            string[] segundalinha = Console.ReadLine().Split(' ');

            int produto2 = Convert.ToInt32(segundalinha[0]);

            int unidades2 = Convert.ToInt32(segundalinha[1]);

            decimal preco2 = Convert.ToDecimal(segundalinha[2]);

            Console.WriteLine("VALOR A PAGAR: R$ " + ((unidades1 * preco1) + (unidades2 * preco2)).ToString("0.00")); 


        }
    }
}
