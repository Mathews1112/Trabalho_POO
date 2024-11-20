using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho_poo.Data_arquivo;
using trabalho_poo.Models;

namespace trabalho_poo.Controllers
{
    internal class PessoaController
    {
        private List<Pessoa> listPessoas;

        public PessoaController() { 
                listPessoas = Data_Pessoa.CarregarDados();
        }

        public void ExibirListaPessoas()
        {
            Console.WriteLine("Lista de pessoas cadastradas");
            foreach (var item in listPessoas)
            {
                Console.WriteLine($"Nome:{item.Nome}\n" +
                    $"Matricula:{item.CodigoPessoa}\n");
            }
        }
        public void ExibirPessoa(string nome)
        {

        }

        public void AdicionarPessoa(Aluno aluno)
        {
            listPessoas.Add(aluno);
            Console.WriteLine("Pessoa Adicionada com sucesso");
            Data_Pessoa.SalvarDados(listPessoas);
        }
    }
}
