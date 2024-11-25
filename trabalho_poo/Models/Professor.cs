using System;

namespace trabalho_poo.Models
{
    internal class Professor : Pessoa
    {

        public string Formacao { get; set; }
        public double Salario { get; set; }
        public Professor(int codigoPessoa, string nome, string cpf, string email, string telefone, string formacao, double salario)
        {
            if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentNullException(nameof(nome), "O nome não pode ser nulo ou vazio.");
            if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11) throw new ArgumentException("O CPF deve conter 11 caracteres numéricos.", nameof(cpf));
            if (!email.Contains("@")) throw new ArgumentException("O e-mail informado é inválido.", nameof(email));
            if (string.IsNullOrWhiteSpace(telefone)) throw new ArgumentNullException(nameof(telefone), "O telefone não pode ser nulo ou vazio.");
            if (string.IsNullOrWhiteSpace(formacao)) throw new ArgumentNullException(nameof(formacao), "A formação não pode ser nula ou vazia.");
            if (salario <= 1400) throw new ArgumentOutOfRangeException(nameof(salario), "O salário deve ser maior que o salário mínimo.");

            CodigoPessoa = codigoPessoa;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Formacao = formacao;
            Salario = salario;
        }

        public override void ExibirInformações()
        {
            Console.WriteLine($"Informações do professor:\n" +
                $"Código: {CodigoPessoa}\n" +
                $"Nome: {Nome}\n" +
                $"CPF: {Cpf}\n" +
                $"Email: {Email}\n" +
                $"Telefone: {Telefone}\n" +
                $"Formação:{Formacao}\n" +
                $"Salario:{Salario}");
        }
    }
}
