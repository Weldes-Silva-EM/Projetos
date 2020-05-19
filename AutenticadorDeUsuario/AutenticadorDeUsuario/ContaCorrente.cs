using System;

namespace Interfaces
{
    class ContaCorrente : IConta
    {
        static void Main(string[] args)
        {

        }
        public double Saldo { get; set; }
        private double taxaPorOperacao = 0.45;

        public void Deposita(double valor)
        {
            Saldo += valor - taxaPorOperacao;
        }
        public void Saca(double valor)
        {
            Saldo -= valor + taxaPorOperacao;
        }

    }
}

