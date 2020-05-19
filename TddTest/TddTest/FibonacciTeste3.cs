using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddTest
{
    class FibonacciTeste3
    {
        public void OTerceiroElementoDaSequenciaDeveSer1()
        {
            Assert.AreEqual(1, Fibonacci.Elemento(2));
        }
    }
}
