using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo.Models.Cursos
{
    internal class CursoPresencial : CursoBase
    {
        public string local_aula {  get; set; }
        public CursoPresencial() : base("", 0) { }
        public CursoPresencial(string nome, int capacidadeMaxima, string local_aula) : base(nome, capacidadeMaxima)
        {
            if (string.IsNullOrWhiteSpace(local_aula))
                throw new ArgumentNullException(nameof(local_aula), "O local da aula não pode estar vazio");
            this.local_aula = local_aula;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($" Curso Presencial\n" +
                $"Curso:{NomeCurso}\n" +
                $"Capacidade Maxima:{CapacidadeMaxima}\n" +
                $"Número de participantes:{Integrantes.Count}\n" +
                $"Local das aulas:{local_aula}\n");
            Console.WriteLine("Pessoas cadastrada no curso");
            foreach (var p in Integrantes)
            {
                Console.WriteLine($"Nome:{p.Nome}\n" +
                    $"{p.CodigoPessoa}");
            }
        }
    }
}
