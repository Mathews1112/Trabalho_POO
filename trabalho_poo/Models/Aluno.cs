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
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentNullException(nameof(nome), "O nome não pode ser nulo ou vazio.");
            if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11) throw new ArgumentException("O CPF deve conter 11 caracteres numéricos.", nameof(cpf));
            if (!email.Contains("@")) throw new ArgumentException("O e-mail informado é inválido.", nameof(email));
            if (string.IsNullOrWhiteSpace(telefone)) throw new ArgumentNullException(nameof(telefone), "O telefone não pode ser nulo ou vazio.");
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
