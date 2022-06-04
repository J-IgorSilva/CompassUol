using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            double N;
            int cem100, cin50, vint20, dez10, cinco5, dois2, real1, moeda50, moeda25, moeda10, moeda5, moeda01;

            N = Convert.ToDouble(Console.ReadLine());
            int notas = (int)N;
            double moedas = (N - notas) * 100;
            if ((moedas * 1000) % 10 == 9)
            {
                moedas++;
            }
            cem100 = notas / 100;
            notas = notas % 100;
            cin50 = notas / 50;
            notas = notas % 50;
            vint20 = notas / 20;
            notas = notas % 20;
            dez10 = notas / 10;
            notas = notas % 10;
            cinco5 = notas / 5;
            notas = notas % 5;
            dois2 = notas / 2;
            notas = notas % 2;

            real1 = notas / 1;
            notas = notas % 1;

            moeda50 = (int)moedas / 50;
            moedas = moedas % 50;
            moeda25 = (int)moedas / 25;
            moedas = moedas % 25;
            moeda10 = (int)moedas / 10;
            moedas = moedas % 10;
            moeda5 = (int)moedas / 5;
            moedas = moedas % 5;
            moeda01 = (int)moedas / 1;


            Console.WriteLine("NOTAS:");
            Console.WriteLine((int)cem100 + " nota(s) de R$ 100.00");
            Console.WriteLine((int)cin50 + " nota(s) de R$ 50.00");
            Console.WriteLine((int)vint20 + " nota(s) de R$ 20.00");
            Console.WriteLine((int)dez10 + " nota(s) de R$ 10.00");
            Console.WriteLine((int)cinco5 + " nota(s) de R$ 5.00");
            Console.WriteLine((int)dois2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(real1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda5 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda01 + " moeda(s) de R$ 0.01");
        }

    }
}
