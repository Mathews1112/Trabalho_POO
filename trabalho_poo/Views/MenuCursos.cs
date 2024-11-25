using System;
using trabalho_poo.Controllers;

namespace trabalho_poo.Views
{
    internal class MenuCursos
    {
        private CursoController _cursoController;

        public MenuCursos( PessoaController pessoaController)
        {
            _cursoController = new CursoController(pessoaController);
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Gerenciar Cursos ===");
                Console.WriteLine("1. Listar Cursos");
                Console.WriteLine("2. Adicionar Curso Online");
                Console.WriteLine("3. Adicionar Curso Presencial");
                Console.WriteLine("4. Adicionar Curso Especial");
                Console.WriteLine("5. Remover Curso");
                Console.WriteLine("6. Adicionar Participante");
                Console.WriteLine("7. Remover Participante");
                Console.WriteLine("8. Voltar");
               
                string opcao = Console.ReadLine();

                try
                {
                    switch (opcao)
                    {
                        case "1":
                            _cursoController.ExibirListaCursos();
                            break;
                        case "2":
                            AdicionarCursoOnline();
                            break;
                        case "3":
                            AdicionarCursoPresencial();
                            break;
                        case "4":
                            AdicionarCursoEspecial();
                            break;
                        case "5":
                            RemoverCurso();
                            break;
                        case "6":
                            AdicionarParticipante();
                            break;
                        case "7":
                            RemoverParticipante();
                            break;
                        case "8":
                            ExibirInformacoesCurso();
                            break;
                        case "9":
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
        private void ExibirInformacoesCurso()
{
    try
    {
        Console.Write("Digite o nome do curso para visualizar: ");
        string nomeCurso = Console.ReadLine();

        _cursoController.ExibirUmCurso(nomeCurso);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro ao exibir o curso: {ex.Message}");
    }
}
        private void AdicionarCursoOnline()
        {
            try
            {
                Console.WriteLine("Digite as informações do Curso Online:");
                Console.Write("Nome do curso: ");
                string nomeCurso = Console.ReadLine();
                Console.Write("Capacidade máxima: ");
                int capacidadeMaxima = int.Parse(Console.ReadLine());
                Console.Write("URL da aula: ");
                string urlAula = Console.ReadLine();

                _cursoController.AdicionarCursoOnline(nomeCurso, capacidadeMaxima, urlAula);

                Console.WriteLine("Curso Online adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar curso: {ex.Message}");
            }
        }

        private void AdicionarCursoPresencial()
        {
            try
            {
                Console.WriteLine("Digite as informações do Curso Presencial:");
                Console.Write("Nome do curso: ");
                string nomeCurso = Console.ReadLine();
                Console.Write("Capacidade máxima: ");
                int capacidadeMaxima = int.Parse(Console.ReadLine());
                Console.Write("Local da aula: ");
                string localAula = Console.ReadLine();

                _cursoController.AdicionarCursoPresencial(nomeCurso, capacidadeMaxima, localAula);

                Console.WriteLine("Curso Presencial adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar curso: {ex.Message}");
            }
        }

        private void AdicionarCursoEspecial()
        {
            try
            {
                Console.WriteLine("Digite as informações do Curso Especial:");
                Console.Write("Nome do curso: ");
                string nomeCurso = Console.ReadLine();
                Console.Write("Capacidade máxima: ");
                int capacidadeMaxima = int.Parse(Console.ReadLine());
                Console.Write("URL da aula: ");
                string urlAula = Console.ReadLine();
                Console.Write("Local da aula: ");
                string localAula = Console.ReadLine();

                _cursoController.AdicionarCursoEspecial(nomeCurso, capacidadeMaxima, urlAula, localAula);

                Console.WriteLine("Curso Especial adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar curso: {ex.Message}");
            }
        }

        private void RemoverCurso()
        {
            try
            {
                Console.WriteLine("=== Remover Curso ===");
                Console.Write("Digite o nome do curso para remover: ");
                string nomeCurso = Console.ReadLine();

                _cursoController.RemoverCurso(nomeCurso);

                Console.WriteLine("Curso removido com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        private void AdicionarParticipante()
        {
            try
            {
                Console.Write("Digite o nome do curso: ");
                string nomeCurso = Console.ReadLine();

                Console.Write("Digite o código da pessoa: ");
                int codigoPessoa = int.Parse(Console.ReadLine());

                _cursoController.AdicionarIntegrante(nomeCurso, codigoPessoa);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar participante: {ex.Message}");
            }
        }


        private void RemoverParticipante()
        {
            try
            {
                Console.Write("Digite o nome do curso: ");
                string nomeCurso = Console.ReadLine();

                Console.Write("Digite o código da pessoa: ");
                int codigoPessoa = int.Parse(Console.ReadLine());

                _cursoController.RemoverParticipante(codigoPessoa, nomeCurso);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover participante: {ex.Message}");
            }
        }

    }
}
