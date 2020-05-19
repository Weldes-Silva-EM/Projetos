using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGenerica
{
    public abstract class Calculadora<T>
    {
        public abstract T Somar(T operando1, T operando2);
        public abstract T Subtrair(T operando1, T operando2);
        public abstract T Multiplicar(T operando1, T operando2);
        public abstract T Dividir(T operando1, T operando2);
    }
}
