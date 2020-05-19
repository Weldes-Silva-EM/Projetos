using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class ContaPoupanca : IConta
    {
        public double Saldo { get; set; }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public void Saca(double valor)
        {
            Saldo -= valor;
        }

        
    }
}
