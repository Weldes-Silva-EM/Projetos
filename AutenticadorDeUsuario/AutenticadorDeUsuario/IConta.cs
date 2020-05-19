using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IConta
    {
        void Deposita(double valor);
        void Saca(double valor);
        double Saldo { get; set; }
    }
}
