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
        public List<Pessoa> listPessoas;

        public PessoaController() { 
                listPessoas = Data_Pessoa.CarregarDados();
        }
        public int GerarCodigoPessoa()
        {
            Random random = new Random();
            return random.Next(1000000, 10000000);
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
        public Pessoa GetPessoa(int codigo)
        {
            return listPessoas.FirstOrDefault(p => p.CodigoPessoa == codigo);

        }
        public void AdicionarPessoa(string nome, string cpf, string email, string telefone)
        {
            bool codigoBool = true;
            int numCodigoIgual = 0;
            int codigo=0;
            while (codigoBool)
            {
                codigo = GerarCodigoPessoa();
                foreach (var item in listPessoas)
                {
                    if (item.CodigoPessoa == codigo)
                    {
                        numCodigoIgual++;
                    }
                }
                if(numCodigoIgual == 0)
                {
                    codigoBool=false;
                }
            }

            Pessoa pessoa = new Aluno(codigo,nome,cpf,email,telefone);
            listPessoas.Add(pessoa);
            Console.WriteLine("Pessoa Adicionada com sucesso");
            Data_Pessoa.SalvarDados(listPessoas);
        }
        public void RemoverPessoa(int codigo)
        {
            var pessoa = listPessoas.FirstOrDefault(p => p.CodigoPessoa == codigo);
            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não existe");
            }
            listPessoas.Remove(pessoa);
            Data_Pessoa.SalvarDados(listPessoas);
        }
    }
}
