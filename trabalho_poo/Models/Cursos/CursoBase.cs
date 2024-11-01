using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo.Models.Cursos
{
    internal class CursoBase : ICursos
    {
        public string NomeCurso {  get; set; }
        public int CapacidadeMaxima { get;  set; }
        public List<Pessoa> Integrantes { get; private set; }

        public CursoBase(string nomeCurso, int capacidadeMaxima) { 
            
           NomeCurso = nomeCurso;
           CapacidadeMaxima = capacidadeMaxima;
           Integrantes = new List<Pessoa>();
        }
        public void AdicionarPessoa(Pessoa pessoa)
        {
            Integrantes.Add(pessoa);
        }
        public void RemoverParticipante(Pessoa pessoa)
        {
            Integrantes.Remove(pessoa);
        }
        public virtual void ExibirInformações() { }
    }
}
