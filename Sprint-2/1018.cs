using System;
using System.Globalization;
using System.IO;

namespace sprint
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, A, B, C, D, E, F, G, H, I, J, K, L, M, N1, O, P, Q, R, S, T, U;

            N = int.Parse(Console.ReadLine());

            A = N / 100;
            B = 100 * A;
            C = N - B;

            D = C / 50;
            E = 50 * D;
            F = C - E;

            G = F / 20;
            H = 20 * G;
            I = F - H;

            J = I / 10;
            K = 10 * J;
            L = I - K;

            M = L / 5;
            N1 = 5 * M;
            O = L - N1;

            P = O / 2;
            Q = 2 * P;
            R = O - Q;

            S = R / 1;
            T = 1 * S;
            U = R - T;

            Console.WriteLine(N);
            Console.WriteLine(A + " nota(s) de R$ 100,00");
            Console.WriteLine(D + " nota(s) de R$ 50,00");
            Console.WriteLine(G + " nota(s) de R$ 20,00");
            Console.WriteLine(J + " nota(s) de R$ 10,00");
            Console.WriteLine(M + " nota(s) de R$ 5,00");
            Console.WriteLine(P + " nota(s) de R$ 2,00");
            Console.WriteLine(S + " nota(s) de R$ 1,00");

        }
    }
}
