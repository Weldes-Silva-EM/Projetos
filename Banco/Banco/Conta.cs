using Banco;
using System;

namespace Banco
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public int Tipo { get; set; }

        public void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

    }

    public class ContaPoupanca
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }

        public Cliente Titular { get; set; }

        public void Saca (double valor)
        {
            this.Saldo -= (valor + 0.10);
        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
