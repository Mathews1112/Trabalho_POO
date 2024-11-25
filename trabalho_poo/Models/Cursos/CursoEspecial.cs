using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo.Models.Cursos
{
    sealed class CursoEspecial : CursoBase
    {
        public string urlAula {  get; set; }
        public string local_aula { get; set; }
        public CursoEspecial() : base("", 0) { }
        public CursoEspecial(string nome, int capacidadeMaxima, string urlAula, string local_aula) : base(nome, capacidadeMaxima) {

            if (string.IsNullOrWhiteSpace(urlAula))
                throw new ArgumentNullException(nameof(urlAula), "A url da aula não pode ser nula");

            if (string.IsNullOrWhiteSpace(local_aula))
                throw new ArgumentNullException(nameof(local_aula), "O local da aula não pode estar vazio");

            this.local_aula = local_aula;
            this.urlAula = urlAula;

        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($" Curso Especial\n" +
                $"Curso:{NomeCurso}\n" +
                $"Capacidade Maxima:{CapacidadeMaxima}\n" +
                $"Número de participantes:{Integrantes.Count}\n" +
                $"Url das aulas do curso:{urlAula}\n" +
                $"Local das aulas:{local_aula}");
            Console.WriteLine("Pessoas cadastrada no curso");
            //foreach (var p in Integrantes)
            //{
                //Console.WriteLine($"Nome:{p.Nome}\n" +
                   // $"{p.CodigoPessoa}");
            //}
        }
    }
}
