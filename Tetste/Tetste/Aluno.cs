using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Aluno
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Aluno aluno &&
                   Nome == aluno.Nome &&
                   Nascimento == aluno.Nascimento;
        }

        public override int GetHashCode()
        {
            int hashCode = -585984586;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Nascimento.GetHashCode();
            return hashCode;
        }

        //public override string ToString()
        //{
        //    return "nome:" + Nome + "idade" + Nascimento;
        //}
    }
}
