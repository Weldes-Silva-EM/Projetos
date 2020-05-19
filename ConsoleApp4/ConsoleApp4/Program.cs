using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 2;
                if (resto == 1)
                {
                    Console.WriteLine("*");
                }
                else
                {
                    Console.WriteLine("**");
                }
            }
        }
    }
}
