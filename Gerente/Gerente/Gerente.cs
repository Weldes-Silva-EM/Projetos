using System;
using System.Collections.Generic;
using System.Text;

namespace Gerente
{
    class Gerente
    {
        public string nome;
        public double salario;

        public void AumentaSalario()
        {
            AumentaSalario(0.1);
        }

        public void AumentaSalario(double taxa)
        {
            salario += salario * taxa; 
        }
    }
}
