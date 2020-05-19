using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddTest
{
    class Fibonacci
    {
        public static int Elemento(int posicao)
        {
            if (posicao == 0) return 0;
            if (posicao == 1) return 1;
            return Elemento(posicao-2) + Elemento(posicao - 1);
        }
    }
}
