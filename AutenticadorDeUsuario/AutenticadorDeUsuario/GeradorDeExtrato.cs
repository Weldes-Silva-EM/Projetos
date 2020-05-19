using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class GeradorDeExtrato
    {
        public void GeraExtrato(IConta c)
        {
            Console.WriteLine("EXTRATO");
            Console.WriteLine("SALDO: " + c.Saldo);
        }
    }
}
