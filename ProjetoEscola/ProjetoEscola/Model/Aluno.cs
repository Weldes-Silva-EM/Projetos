using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Model
{
    public class Aluno
    {
        public string nome { get; set; }

        public int Matricula;

        public string Nome, Cpf;

        public DateTime Nascimento;

        public EnumSexo Sexo;
    }
    
}
