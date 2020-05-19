using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 1; contador <= 100; contador++)
            {
                int resto = contador % 4;
                if (resto == 0)
                {
                    Console.WriteLine("PI");
                }
                else
                    Console.WriteLine("Contador");
            }   
        }
    }
}
