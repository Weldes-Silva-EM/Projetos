using System;

namespace GetHashCode3
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa1 = new Pessoa("Maria");
            Pessoa pessoa2 = new Pessoa("João");
            Console.Write(pessoa1.Nome);
            Console.WriteLine(" "+ pessoa1.GetHashCode());
            Console.Write(pessoa2.Nome);
            Console.WriteLine(" "+ pessoa2.GetHashCode());

            Console.ReadKey();
        
        
        
        
        }
            

       
    }
}

