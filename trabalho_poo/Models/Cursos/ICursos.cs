using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo.Models.Cursos
{
    internal interface ICursos
    {
        string NomeCurso { get; }
        int CapacidadeMaxima {  get; }
        void AdicionarPessoa(Pessoa pessoa);
        void RemoverParticipante (Pessoa pessoa);
        void ExibirInformacoes();
    }
}
