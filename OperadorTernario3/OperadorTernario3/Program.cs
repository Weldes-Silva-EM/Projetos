using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OperadorTernario3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a média do aluno?");
            double media = double.Parse(Console.ReadLine().Replace(",", "."), CultureInfo.InvariantCulture);

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno Aprovado!", ("F2", CultureInfo.InvariantCulture));
            }
            else if (media < 7.0 && media >= 5.0)
            {
                Console.WriteLine("Aluno em Recuperação!", ("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Aluno Reprovado!", ("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
