using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEx
{
    public class Calculadora<T>
    {
        public T Add(T v1, T v2)
        {
            return v1 + v2;
        }
    }
}
