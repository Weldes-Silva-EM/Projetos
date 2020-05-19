using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcGenerica
{
    public class CalcularOperacoes<T> where T : new()
    {
        Calculadora<T> calculadora;

        public CalcularOperacoes(Calculadora<T> _calculadora)
        {
            this.calculadora = _calculadora;
        }

        public T Somar(List<T> items)
        {
            T soma = new T();
            for (int i = 0; i < items.Count; i++)
            {
                soma = calculadora.Somar(soma, items[i]);
            }
            return soma;
        }

        public T Subtrair(List<T> items)
        {
            dynamic subtrair = new T();
            for (int i = 0; i < items.Count; i++)
            {
                if (i == 0)
                {
                    subtrair = calculadora.Subtrair(subtrair, items[i]);
                    subtrair = subtrair * -1;
                }
                else
                {
                    subtrair = calculadora.Subtrair(subtrair, items[i]);
                }

            }
            return subtrair;
        }

        public T Multiplicar(List<T> items)
        {
            dynamic multiplicar = 1;
            for (int i = 0; i < items.Count; i++)
            {
                multiplicar = calculadora.Multiplicar(multiplicar, items[i]);
            }
            return multiplicar;
        }
        public T Dividir(List<T> items)
        {
            dynamic dividir = 1;
            for (int i = 0; i < items.Count; i++)
            {
                if (dividir == 1)
                {
                    dividir = calculadora.Dividir(items[i], dividir);
                }
                else
                {
                    dividir = calculadora.Dividir(dividir, items[i]);
                }
            }
            return dividir;

        }
    }
}
