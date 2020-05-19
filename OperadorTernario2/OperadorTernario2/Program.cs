using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorTernario2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime agora = DateTime.Now;
            Console.WriteLine("Hoje é: {0} ", agora.ToString());
            string saudacao = "";

            saudacao = agora.Hour > 12 ? "Boa Tarde!" : "Bom dia!";

            Console.WriteLine($"Agora são {agora.Hour} horas, {agora.Minute} minutos e {agora.Second} segundos");
            Console.WriteLine(saudacao);
            Console.ReadKey();
        }
    }
}
