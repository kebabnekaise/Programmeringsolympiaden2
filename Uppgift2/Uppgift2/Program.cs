using System;
using System.Diagnostics.CodeAnalysis;

namespace uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N?");
            int N = int.Parse(Console.ReadLine());
            float check = (float)N;

            int solution = 0;
            
            for (int i = 1; i <= N/2; i++)
            {
                int treigt = i * (i + 1) * (i + 2);
                if (treigt < N)
                {
                    solution++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Svar: " + solution);
        }
    }
}