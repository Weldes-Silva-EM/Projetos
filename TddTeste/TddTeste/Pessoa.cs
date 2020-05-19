using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddTeste
{
    class Pessoa : Entidade
    {
        public Pessoa(string cpf, string nome)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                throw new Excecao.ExcecaoCPFInvalido("Pessoa.Cpf");

            this.Cpf = (string)cpf;
            this.Nome = nome;
        }

        public virtual string Cpf { get; protected set; }

        public virtual string nome { get; set; }
    }
}
