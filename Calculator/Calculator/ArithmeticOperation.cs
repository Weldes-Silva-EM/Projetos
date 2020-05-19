using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericCalculator
{
    public class ArithmeticOperation<T>
    {
        AbstractCalculator<T> _myCalculator;

        public ArithmeticOperation(AbstractCalculator<T> myCalculator)
        {
            this._myCalculator = myCalculator;
        }
        public T Sum(List<T>items)
        {
            dynamic sum = 0;

            for (int i = 0; i < items.Count; i++)
            {
                sum = _myCalculator.Add(sum, items[i]);
            }

            return sum;
        }

        public T Sub(List<T> items)
        {
            dynamic sub = 0;
            for (int i = 0; i < items.Count; i++)
            {
                sub = _myCalculator.Sub(sub, items[i]);
            }

            return sub;
        }

        public T Multiply(List<T> items)
        {
            dynamic mul = 1;
            for (int i = 0; i < items.Count; i++)
            {
                mul = _myCalculator.Multiply(mul, items[i]);
            }

            return mul;
        }

        public T Divide(List<T> items)
        {
            dynamic div = 1;
            for (int i = 0; i < items.Count; i++)
            {
                if (div == 1)
                {
                    div = _myCalculator.Divide(items[i], div);
                }
                else
                {
                    div = _myCalculator.Divide(div, items[i]);
                }
            }

            return div;
        }
    }
}
