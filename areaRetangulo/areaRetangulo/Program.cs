using System;

namespace areaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do retangulo:");

            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do retangulo:");

            double largura = double.Parse(Console.ReadLine());

            double area = altura * largura;

            Console.WriteLine("O valor da área calculado é: " + area);


            Console.ReadKey();
            Console.ReadLine();



        }
    }
}
