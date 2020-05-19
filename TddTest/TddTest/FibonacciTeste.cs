using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddTest
{
    class FibonacciTeste
    {
        public void OPrimeiroElementoDaSequenciaDeveSer0()
        {
            Assert.AreEqual(0, Fibonacci.Elemento(0));
        }
    }
}
