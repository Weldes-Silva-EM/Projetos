using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class GeradorDeExtrato
    {
        public void ImprimeExtratoBasico(Conta c)
        {
            DateTime agora = DateTime.Now;
            string horario = string.Format($"{agora}");

            Console.WriteLine("DATA: " + horario);
            Console.WriteLine("SALDO: " + c.Saldo);
        }        
    }
}
