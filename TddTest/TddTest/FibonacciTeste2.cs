using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddTest
{
    class FibonacciTeste2
    {
        public void OSegundoElementoDaSequenciaDeveSer1()
        {
            Assert.AreEqual(1, Fibonacci.Elemento(1));
        }
    }
}
