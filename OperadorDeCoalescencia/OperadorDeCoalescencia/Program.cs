using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorDeCoalescencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario = null;

            if (usuario == null)
            {
                Console.WriteLine("Olá, Tudo Bem!");
            }
            else
            {
                Console.WriteLine("Olá," + usuario);
            }
            Console.ReadKey();
        }
    }
}
