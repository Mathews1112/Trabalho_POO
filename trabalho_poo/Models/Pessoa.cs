using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo.Models
{
    public abstract class Pessoa
    {

        public int CodigoPessoa { get; set; }
        public string Nome { get; set; }
        public string Cpf {  get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public  virtual void ExibirInformações() { }

    }
}
