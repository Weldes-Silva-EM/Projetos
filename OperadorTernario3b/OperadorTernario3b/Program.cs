using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OperadorTernario3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a média do aluno?");
            double media = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string resultado = ("Olá aluno, você foi: ");
            resultado += media >= 7.0 ? "[Aprovado!]" : "[Reprovado]";

            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
