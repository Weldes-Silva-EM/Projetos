using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class TestaGeradorDeExtrato
    {
        public static void Main()
        {
            var gerador = new GeradorDeExtrato();

            var cp = new ContaPoupanca();
            cp.Saldo = 2000;

            var cc = new ContaCorrente();
            cc.Saldo = 1000;

            gerador.ImprimeExtratoBasico(cp);
            gerador.ImprimeExtratoBasico(cc);

            Console.ReadKey();

        }
    }
}
