using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using trabalho_poo.Models.Cursos;

namespace trabalho_poo.Models
{
    [JsonDerivedType(typeof(Aluno), nameof(Aluno))]
    [JsonDerivedType(typeof(Professor), nameof(Professor))]

    internal class Pessoa
    { 
        public int CodigoPessoa { get; set; }
        public string Nome { get; set; }
        public string Cpf {  get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public  virtual void ExibirInformações() { }

        public Pessoa() { }
    }
}
