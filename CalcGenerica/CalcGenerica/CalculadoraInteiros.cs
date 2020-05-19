using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGenerica
{
    class CalculadoraInteiros : Calculadora<int>
    {
        public override int Somar(int operando1, int operando2)
        {
            return operando1 + operando2;
        }

        public override int Dividir(int operando1, int operando2)
        {
            return operando1 / operando2;
        }

        public override int Multiplicar(int operando1, int operando2)
        {
            return operando1 * operando2;
        }

        public override int Subtrair(int operando1, int operando2)
        {
            return operando1 - operando2;
        }
    }
}
