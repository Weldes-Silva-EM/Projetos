using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class TestaContas
    {
        static void Main()
        {
            ContaCorrente c1 = new ContaCorrente();
            ContaPoupanca c2 = new ContaPoupanca();

            c1.Deposita(500);
            c2.Deposita(500);

            c1.Saca(100);
            c2.Saca(100);

            Console.WriteLine(c1.Saldo);
            Console.WriteLine(c2.Saldo);
        }
    }
}
