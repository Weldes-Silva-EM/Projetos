using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Control
{
    public abstract class RepositorioAbstratoAluno<T>

    {
        public void Add(T Aluno) { }
        public void Remove(T Aluno) { }
        public void Update(T Aluno) { }

    }

   }
