using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIs
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cachorro = new Cao();
            var pessoa = new Pessoa();
            pessoa.Nome = "João";
            pessoa.Idade = 15;

            Console.WriteLine($"Cachorro é um Cão? { cachorro is Cao}");
            Console.WriteLine($"Pessoa é um Cão? {pessoa is Cao}");
            Console.WriteLine($"Cachorro é uma Animal? {cachorro is Animal}");
            Console.WriteLine($"Pessoa é um Animal Racional? {pessoa is Animal}");

            Console.ReadLine();
        }
    }
}
