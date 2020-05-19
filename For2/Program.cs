using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor de #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());

                soma += valor;             
            }
            Console.WriteLine("Soma = " + soma);
            Console.ReadKey();
        }
    }
}

