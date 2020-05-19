using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularOperacoes<int> calculos = new CalcularOperacoes<int>(new CalculadoraInteiros());
            List<int> numeros = new List<int> { 9, 3, -1, 5, 2, 4 };

            Console.WriteLine("Calculadora de Inteiros");

            Console.WriteLine("Operações com números : 9, 3, -1, 5, 2, 4 ");
            Console.WriteLine($"Adição : {calculos.Somar(numeros)}");
            Console.WriteLine($"Subtração : {calculos.Subtrair(numeros)}");
            Console.WriteLine($"Multiplicação : {calculos.Multiplicar(numeros)}");
            Console.WriteLine($"Divisão : {calculos.Dividir(numeros)}");

            Console.ReadLine();
        }
    }
}
