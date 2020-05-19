using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorDeCoalescencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario = null;
            Console.WriteLine("Olá, " + (usuario ?? "Tudo Bem!"));

            Console.ReadKey();
        }
    }
}
