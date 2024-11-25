using System;
using System.Collections.Generic;
using System.Linq;
using trabalho_poo.Data_arquivo;
using trabalho_poo.Models;
using trabalho_poo.Excecoes;

namespace trabalho_poo.Controllers
{
    internal class PessoaController
    {
        public List<Pessoa> listPessoas;

        public PessoaController()
        {
            try
            {
                listPessoas = Data_Pessoa.CarregarDados();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar os dados das pessoas: {ex.Message}");
                listPessoas = new List<Pessoa>();
            }
        }

        public int GerarCodigoPessoa()
        {
            Random random = new Random();
            return random.Next(1000000, 10000000);
        }

        public void ExibirListaPessoas()
        {
            try
            {
                if (!listPessoas.Any())
                {
                    Console.WriteLine("Nenhuma pessoa cadastrada.");
                    return;
                }

                Console.WriteLine("Lista de pessoas cadastradas:");
                foreach (var item in listPessoas)
                {
                    Console.WriteLine($"Nome: {item.Nome}\n" +
                        $"Matrícula: {item.CodigoPessoa}\n" +
                        $"Cursos incristos:{string.Join(", ", item.CursosInscritos)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exibir lista de pessoas: {ex.Message}");
            }
        }

        public void ExibirPessoa(string nome)
        {
            try
            {
                var pessoa = listPessoas.FirstOrDefault(p => p.Nome.Equals(nome));
                if (pessoa == null)
                    throw new ExcecaoPessoa.PessoaNaoEncontrada(nome);

                Console.WriteLine($"Nome: {pessoa.Nome}\n" +
                    $"Código: {pessoa.CodigoPessoa}\n" +
                    $"Cursos inscritos: {string.Join(", ",pessoa.CursosInscritos)}");
            }
            catch (ExcecaoPessoa.PessoaNaoEncontrada ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exibir pessoa: {ex.Message}");
            }
        }

        public Pessoa GetPessoa(int codigo)
        {
            try
            {
                var pessoa = listPessoas.FirstOrDefault(p => p.CodigoPessoa == codigo);
                if (pessoa == null)
                    throw new ExcecaoPessoa.PessoaNaoEncontrada(codigo);

                return pessoa;
            }
            catch (ExcecaoPessoa.PessoaNaoEncontrada ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter pessoa: {ex.Message}");
                return null;
            }
        }

        public void AdicionarAluno(string nome, string cpf, string email, string telefone)
        {
            try
            {
                foreach (var a in listPessoas)
                {
                    if( a.Nome.ToLower() == nome.ToLower())
                    {
                        throw new ExcecaoPessoa.PessoaJaCadastrada(nome);
                        break;
                    }
                }

                bool codigoBool = true;
                int numCodigoIgual = 0;
                int codigo = 0;
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
                    if (numCodigoIgual == 0)
                    {
                        codigoBool = false;
                    }
                }

                var pessoa = new Aluno(codigo, nome, cpf, email, telefone);
                listPessoas.Add(pessoa);
                Data_Pessoa.SalvarDados(listPessoas);

                Console.WriteLine("Aluno adicionado com sucesso.");
            }
            catch (ExcecaoPessoa.PessoaJaCadastrada ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar pessoa: {ex.Message}");
            }
        }
        public void AdicionarProfessor(string nome, string cpf, string email, string telefone, string formacao, double salario)
        {
            try
            {
                foreach (var a in listPessoas)
                {
                    if (a.Nome.ToLower() == nome.ToLower())
                    {
                        throw new ExcecaoPessoa.PessoaJaCadastrada(nome);
                        break;
                    }
                }

                bool codigoBool = true;
                int numCodigoIgual = 0;
                int codigo = 0;
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
                    if (numCodigoIgual == 0)
                    {
                        codigoBool = false;
                    }
                }

                var pessoa = new Professor(codigo, nome, cpf, email, telefone, formacao, salario);
                listPessoas.Add(pessoa);
                Data_Pessoa.SalvarDados(listPessoas);

                Console.WriteLine("Professor adicionado com sucesso.");
            }
            catch (ExcecaoPessoa.PessoaJaCadastrada ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar pessoa: {ex.Message}");
            }
        }

        public void RemoverPessoa(int codigo)
        {
            try
            {
                var pessoa = listPessoas.FirstOrDefault(p => p.CodigoPessoa == codigo);
                if (pessoa == null)
                    throw new ExcecaoPessoa.PessoaNaoEncontrada(codigo);

                listPessoas.Remove(pessoa);
                Data_Pessoa.SalvarDados(listPessoas);

                Console.WriteLine("Pessoa removida com sucesso.");
            }
            catch (ExcecaoPessoa.PessoaNaoEncontrada ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover pessoa: {ex.Message}");
            }
        }
    }
}
