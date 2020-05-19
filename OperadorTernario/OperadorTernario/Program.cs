using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime agora = DateTime.Now;
            Console.WriteLine("Hoje é: {0} ", agora.ToString());
            string saudacao = "";

            if (agora.Hour > 12)
            {
                saudacao += "Boa Tarde!";
            }
            else
            {
                saudacao += "Bom Dia!";
            }
            Console.WriteLine($"Agora são {agora.Hour} horas, {agora.Minute} minutos e {agora.Second} segundos");
            Console.WriteLine(saudacao);
            Console.ReadKey();
        }
    }
}
