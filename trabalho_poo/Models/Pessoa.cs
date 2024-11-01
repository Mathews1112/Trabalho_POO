using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo.Models
{
    public abstract class Pessoa
    {

        protected int CodigoPessoa { get; set; }
        protected string Nome { get; set; }
        protected string Cpf {  get; set; }
        protected string Email { get; set; }
        protected string Telefone { get; set; }
        public  virtual void ExibirInformações() { }

    }
}
