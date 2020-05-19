using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddTeste
{
    class Dado_Uma_Pessoa
    {
        public void Quando_Crio_Deve_Ser_Valida()
            //arrange:
        string cpf = "12345678909";
        string nome = "Manuel da Silva";

        //act:
        Pessoa pessoa = new Pessoa(cpf, nome);

        //assert:
        Assert.IsNotNull(pessoa);
        Assert.IsTrue(pessoa.Cpf == cpf);
        Assert.IsTrue(pessoa.Nome == nome);
    }
}
