using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddTeste
{
    class Entidade
    {
        public void Nao_Devo_Conseguir_Criar_Sem_Cpf()
        {
            //arrange:
            var cpf = null;
            string nome = "Fulano da Silva";

            //act:
            Pessoa pessoa = new Pessoa(cpf, nome);

            //assert:
            //O esperado para este teste é uma exceção não deixando eu instanciar
            //a classe Pessoa.
        }
    }
}
