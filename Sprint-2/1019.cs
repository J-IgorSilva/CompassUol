using System;
using System.Globalization;
using System.IO;

namespace sprint
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorInicial, restoTempo, horas, minutos, segundos;

            valorInicial = int.Parse(Console.ReadLine());


            horas = valorInicial / 3600;
            restoTempo = valorInicial % 3600;


            minutos = restoTempo / 60;
            restoTempo = restoTempo % 60;
            segundos = restoTempo;
            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
