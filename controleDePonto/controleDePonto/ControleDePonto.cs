using System;
using System.Collections.Generic;
using System.Text;

namespace controleDePonto
{
    class ControleDePonto
    {
        public void RegistraEntrada(Funcionario f);
        {
        DateTime agora = DateTime.Now;
        string horario = String.Format("{0:d/M/yyyy HH:mm:ss}", agora);

        Console.WriteLine("ENTRADA: " + f.codigo);
        Console.WhirteLine("Data: "   + horario);
        }
    public void RegistraSaida(Funcionario f)
    {
        DateTime agora = DateTime.Now;
        string horario = String.Format("{0:d/M/yyyy HH:mm:ss}", agora);

        Console.WriteLine("SAÍDA: " + f.codigo);
        Console.WriteLine("Data: " + horario);
    }

}
}
