using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_poo.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno(int codigoPessoa, string nome, string cpf, string email, string telefone)
        {
            CodigoPessoa = codigoPessoa;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
        }

        public override void ExibirInformações()
        {
            Console.WriteLine($"Informações do Aluno:\n" +
                $"Código: {CodigoPessoa}\n" +
                $"Nome: {Nome}\n" +
                $"CPF: {Cpf}\n" +
                $"Email: {Email}\n" +
                $"Telefone: {Telefone}");
        }

    }
}
