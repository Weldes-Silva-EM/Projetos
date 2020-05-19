using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de int

            Calcular<int> calculo = new Calcular<int>();
            calculo.Add(1, 2);
            Console.WriteLine(calculo.ToString());
            Console.WriteLine();
            Console.ReadKey();

            //Exemplo de string
            
            Calcular<string> calculo2 = new Calcular<string>();
            calculo2.Add("ABC", "DEF");
            Console.WriteLine(calculo2.ToString());
            Console.WriteLine();
            Console.ReadKey();
            Calcular<double> calculo3 = new Calcular<double>();
            
            calculo3.Add(10, 20);
            Console.WriteLine(calculo3.ToString());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
    public class Calcular<T>
    {
        public dynamic Resultado { get; set; }
        public Calcular()
        {
        }
        public T Add(T value1, T value2)
        {
            Resultado = (dynamic)value1 + value2;
            return Resultado;
        }
        public override string ToString()
        {
            return $@" Resultado: {Resultado}";
        }
        public override bool Equals(object obj)
        {
            return obj is global::CalculatorGeneric.Calcular<T> calcular &&
                   global::System.Collections.Generic.EqualityComparer<dynamic>.Default.Equals(this.Resultado, calcular.Resultado);
        }
        public override int GetHashCode()
        {
            return -2028103174 + EqualityComparer<dynamic>.Default.GetHashCode(Resultado);
        }
    }
}
