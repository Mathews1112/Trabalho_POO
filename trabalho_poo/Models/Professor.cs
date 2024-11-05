using System;

namespace trabalho_poo.Models
{
    internal class Professor : Pessoa
    {
        public int CodigoPessoa { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

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
