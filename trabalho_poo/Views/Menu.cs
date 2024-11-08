using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho_poo.Controllers;
using trabalho_poo.Models;

namespace trabalho_poo.Views
{
    internal class Menu
    {
        public static void Main(string[] args)
        {
            int codMenu = 1;
            CursoController cursoController = new CursoController();
            do
            {
                Console.WriteLine();
                Console.WriteLine("Bem-vindo ao controle de cursos");
                Console.WriteLine("Digite um número para operação que deseja fazer:\n" +
                    "1-Listar todos os cursos\n" +
                    "2-Detalhes de um curso\n" +
                    "3-Cadastrar Pessoa a um curso\n" +
                    "4-Remover Pessoa de um curso\n" +
                    "5-Adicionar curso\n" +
                    "6-Remover curso\n" +
                    "0-Sair do menu");
                codMenu = int.Parse(Console.ReadLine());
               
                switch (codMenu)
                {
                    case 1:
                        cursoController.ExibirListaCursos();
                        break;
                    case 2:
                        cursoController.ExibirInformacao("matematica");
                        break;
                    case 3:
                        Console.WriteLine("Codigo Pessoa");
                        int codPessoa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insira o nome completo da pessoa");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Cpf:");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Email:");
                        string email = Console.ReadLine();
                        Console.WriteLine("Telefone:");
                        string telefone = Console.ReadLine();

                        Pessoa pessoa = new Aluno(codPessoa, nome, email, cpf, telefone);
                        pessoa.ExibirInformações();

                        cursoController.AdicionarIntegrante("ingles", pessoa);


                        break;

                }
            }
            while (codMenu != 0);
        }

    }
}
