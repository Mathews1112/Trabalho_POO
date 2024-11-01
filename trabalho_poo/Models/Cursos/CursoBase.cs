using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo.Models.Cursos
{
    internal class CursoBase : ICursos
    {
        public string NomeCurso {  get; private set; }
        public int CapacidadeMaxima { get; private set; }
        protected List<Pessoa> Integrantes { get; private set; }

        protected CursoBase(string nome, int capacidadeMaxima) { 
            
           NomeCurso = nome;
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
