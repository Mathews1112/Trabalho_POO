using System;

namespace trabalho_poo.Models
{
    internal class Professor : Pessoa
    {
        public int CodigoPessoa { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }

        public Professor(int codigoPessoa, string nome, string cpf, string email, string telefone)
        {
            CodigoPessoa = codigoPessoa;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
        }

        public override void ExibirInformações()
        {
            Console.WriteLine($"Informações do professor:\n" +
                $"Código: {CodigoPessoa}\n" +
                $"Nome: {Nome}\n" +
                $"CPF: {Cpf}\n" +
                $"Email: {Email}\n" +
                $"Telefone: {Telefone}");
        }
    }
}
