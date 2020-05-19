using System;
using System.Collections.Generic;
using System.Text;

namespace GetHashCode3
{
    public class Pessoa
    {

        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public override bool Equals(object obj)
        {
            return obj is Pessoa pessoa &&
                   Nome == pessoa.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome);
        }
    }
}
