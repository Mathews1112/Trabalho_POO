using System;
using trabalho_poo.Controllers;
using trabalho_poo.Views;

namespace trabalho_poo.Views
{
    internal class Menu
    {
        private MenuPessoas _menuPessoas;
        private MenuCursos _menuCursos;

        public Menu(PessoaController pessoController)
        {
            _menuPessoas = new MenuPessoas(pessoController);
            _menuCursos = new MenuCursos(pessoController);
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Gerenciamento ===");
                Console.WriteLine("1. Gerenciar Pessoas");
                Console.WriteLine("2. Gerenciar Cursos");
                Console.WriteLine("3. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        _menuPessoas.ExibirMenu();
                        break;
                    case "2":
                        _menuCursos.ExibirMenu();
                        break;
                    case "3":
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
