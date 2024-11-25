using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public List<Pessoa> Integrantes { get; set; }

        public CursoBase() {
            Integrantes = new List<Pessoa>();
        }

        public CursoBase(string nomeCurso, int capacidadeMaxima)
        {
            if (string.IsNullOrWhiteSpace(nomeCurso))
                throw new ArgumentNullException(nameof(nomeCurso), "O nome do curso não pode ser nulo ou vazio.");

            if (capacidadeMaxima < 0)
                throw new ArgumentOutOfRangeException(nameof(capacidadeMaxima), "A capacidade máxima não pode ser menor que zero.");

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
                return this.NomeCurso.ToLower() == curso.NomeCurso.ToLower();
            }
            return false;
        }
        public virtual void ExibirInformacoes() { }
    }
}
