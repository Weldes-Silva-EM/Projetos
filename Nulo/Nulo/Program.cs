using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulo
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 1;
            var j = 2;
            var k = i == 1 ? i : j;

            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine("----------------------");

            object a = 3;
            var b = new obj("abc");
            object x = a ?? b;

            Console.WriteLine(b.ToString());
            Console.WriteLine(x);
            Console.ReadKey();
        }
        public class obj
        {
            string nome;

            public obj (string nome)
            {
                this.nome = nome;

            }
            public override string ToString()
            {
                return base.ToString();
            }
        }
    }
}
