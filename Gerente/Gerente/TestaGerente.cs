using System;

namespace Gerente
{
    public class TestaGerente
    {
        static void Main(string[] args)
        {
            Gerente g = new Gerente();
            g.salario = 1000;

            Console.WriteLine("Salário: " + g.salario);

            Console.WriteLine("Aumentando o salário em 10% ");
            g.AumentaSalario(0.1);

            Console.WriteLine("Aumentando o salário em 30% ");
            g.AumentaSalario(0.3);

            Console.WriteLine("Salário: " + g.salario);



            Console.ReadKey();
        }
    }
}


