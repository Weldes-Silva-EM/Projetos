using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            object num1 = 10m;
            int num2 = 10;

            //Console.WriteLine(num1 == num2);
            Console.WriteLine(num1.Equals(num2));
            Console.WriteLine(num1 is int);
            Console.WriteLine((int)num1);
            Console.ReadKey();
        }
    }
}
