using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo.Models.Cursos
{
    internal class CursoOnline : CursoBase
    {
        public CursoOnline(string nome, int capacidadeMaxima):base(nome,capacidadeMaxima) {}

        public override void ExibirInformações()
        {
            Console.WriteLine($" Curso Online\n" +
                $"Curso:{NomeCurso}\n" +
                $"Capacidade Maxima:{CapacidadeMaxima}\n" +
                $"Número de participantes:{Integrantes.Count}");
        }
    }
}
