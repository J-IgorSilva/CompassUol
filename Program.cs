using System;
using System.Globalization;
using System.IO;

namespace sprint
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendas, total;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = vendas * 15.0 / 100 + salario;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }  
    }
}
