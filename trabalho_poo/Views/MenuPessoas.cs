using System;
using trabalho_poo.Controllers;

namespace trabalho_poo.Views
{
    internal class MenuPessoas
    {
        private PessoaController _pessoaController;

        public MenuPessoas(PessoaController pessoaController)
        {
            _pessoaController = pessoaController;
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Gerenciar Pessoas ===");
                Console.WriteLine("1. Listar Pessoas");
                Console.WriteLine("2. Adicionar Aluno");
                Console.WriteLine("3. Adicionar Professor");
                Console.WriteLine("4. Remover Pessoa");
                Console.WriteLine("5. Exibir Informações de uma Pessoa");
                Console.WriteLine("6. Voltar");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                try
                {
                    switch (opcao)
                    {
                        case "1":
                            _pessoaController.ExibirListaPessoas();
                            break;
                        case "2":
                            AdicionarAluno();
                            break;
                        case "3":
                            AdicionarProfessor();
                            break;
                        case "4":
                            RemoverPessoa();
                            break;
                        case "5":
                            ExibirInformacoesPessoa();
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private void ExibirInformacoesPessoa()
        {
            try
            {
                Console.Write("Digite o nome da pessoa para visualizar: ");
                string nomePessoa = Console.ReadLine();

                _pessoaController.ExibirPessoa(nomePessoa);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exibir a pessoa: {ex.Message}");
            }
        }

        private void AdicionarAluno()
        {
            try
            {
                Console.WriteLine("Digite as informações do Aluno");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();

                _pessoaController.AdicionarAluno(nome, cpf, email, telefone);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar aluno: {ex.Message}");
            }
        }

        private void AdicionarProfessor()
        {
            try
            {
                Console.WriteLine("Digite as informações do Professor");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();
                Console.Write("Formação: ");
                string formacao = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                _pessoaController.AdicionarProfessor(nome, cpf, email, telefone, formacao, salario);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar professor: {ex.Message}");
            }
        }

        private void RemoverPessoa()
        {
            try
            {
                Console.Write("Digite o código da pessoa para remover: ");
                int codigo = int.Parse(Console.ReadLine());

                _pessoaController.RemoverPessoa(codigo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover pessoa: {ex.Message}");
            }
        }
    }
}
