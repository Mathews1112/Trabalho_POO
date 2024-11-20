using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo.Models.Cursos
{
    sealed class CursoEspecial : CursoBase
    {

        public CursoEspecial() : base("", 0) { }
        public CursoEspecial(string nome, int capacidadeMaxima) : base(nome, capacidadeMaxima) { } 
    }
}
