using System;
using System.Globalization;
using System.IO;

namespace sprint
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, ano, mes, dias;

            idade = int.Parse(Console.ReadLine());

            ano = idade / 365;
            mes = (idade % 365) / 30;
            dias = (idade % 365) % 30;

            Console.WriteLine(ano + " ano(s)\n" + mes + " mes(es)\n" + dias + " dia(s)");
        }
    }
}
