using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator4
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora x = new Calculadora();

            //Console.WriteLine("Digite o primeiro e o segundo número a ser somado:");

            //int n1 = int.Parse(Console.ReadLine());

            //int n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(n1 + n2);
            
            Console.WriteLine($"O resultado é: {x.add(-10, 50)}");

            Console.ReadLine();

        }
    }
}
