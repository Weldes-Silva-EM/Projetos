using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class TestaGeradorDeExtrato
    {
        static void Main()
        {
            ContaCorrente c1 = new ContaCorrente();
            ContaPoupanca c2 = new ContaPoupanca();

            c1.Deposita(500);
            c2.Deposita(500);

            GeradorDeExtrato g = new GeradorDeExtrato();
            g.GeraExtrato(c1);
            g.GeraExtrato(c2);
        }
    }
}
