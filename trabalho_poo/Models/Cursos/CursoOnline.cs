using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo.Models.Cursos
{
    internal class CursoOnline : CursoBase
    {
        public string urlAula { get; set; }
        public CursoOnline() : base("", 0) { }
        public CursoOnline(string nome, int capacidadeMaxima, string urlAula) : base(nome, capacidadeMaxima)
        {
            if (string.IsNullOrWhiteSpace(urlAula))
                throw new ArgumentNullException(nameof(urlAula), "A url da aula não pode ser nula");
            this.urlAula = urlAula;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($" Curso Online\n" +
                $"Curso:{NomeCurso}\n" +
                $"Capacidade Maxima:{CapacidadeMaxima}\n" +
                $"Número de participantes:{Integrantes.Count}\n" +
                $"Url das aulas do curso:{urlAula}\n" );
            Console.WriteLine("Pessoas cadastrada no curso");
            //foreach (var p in Integrantes) {
                //Console.WriteLine($"Nome:{p.Nome}\n" +
                    //$"{p.CodigoPessoa}");
            //}
        }
    }
}
