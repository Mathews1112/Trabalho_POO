using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace trabalho_poo.Models.Cursos
{
   [JsonDerivedType(typeof(CursoOnline), nameof(CursoOnline))]
   [JsonDerivedType(typeof(CursoPresencial), nameof(CursoPresencial))]

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
        public override bool Equals(object obj)
        {
            if (obj is CursoBase curso)
            {
                return this.NomeCurso == curso.NomeCurso;
            }
            return false;
        }
        public virtual void ExibirInformações() { }
    }
}
