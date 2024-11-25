using System;
using System.Collections.Generic;
using trabalho_poo.Data_arquivo;
using trabalho_poo.Models;
using trabalho_poo.Models.Cursos;
using trabalho_poo.Excecoes;

namespace trabalho_poo.Controllers
{
    internal class CursoController
    {
        private List<CursoBase> cursoBaseList;
        private PessoaController _pessoas;

        public CursoController(PessoaController pessoaController)
        {
            _pessoas = pessoaController;

            try
            {
                cursoBaseList = Data.CarregarDados();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar os dados dos cursos: {ex.Message}");
                cursoBaseList = new List<CursoBase>();
            }
        }

        public void ExibirListaCursos()
        {
            try
            {
                if (cursoBaseList == null || cursoBaseList.Count == 0)
                {
                    Console.WriteLine("Nenhum curso cadastrado.");
                    return;
                }

                foreach (var curso in cursoBaseList)
                {
                    Console.WriteLine($"Curso: {curso.NomeCurso}");
                    Console.WriteLine($"Capacidade Máxima: {curso.CapacidadeMaxima}");
                    Console.WriteLine($"Número de Participantes: {curso.Integrantes.Count}");

                    if (curso.Integrantes.Count > 0)
                    {
                        Console.WriteLine("Integrantes:");
                        foreach (var integrante in curso.Integrantes)
                        {
                            Console.WriteLine($"- Nome: {integrante.Nome}");
                            Console.WriteLine($"  Código: {integrante.CodigoPessoa}");
                            Console.WriteLine($"  CPF: {integrante.Cpf}");
                            Console.WriteLine($"  E-mail: {integrante.Email}");
                            Console.WriteLine($"  Telefone: {integrante.Telefone}");
                            Console.WriteLine();
                            if (integrante is Professor professor)
                            {

                                Console.WriteLine($"  Formação: {professor.Formacao}");
                                Console.WriteLine($"  Salário: {professor.Salario:C}");
                            }
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Nenhum integrante inscrito.");
                    }

                    Console.WriteLine(new string('-', 40));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exibir a lista de cursos: {ex.Message}");
            }
        }
        public void ExibirUmCurso(string nome)
        {
            try
            {
                var curso = cursoBaseList.Find(c => c.NomeCurso.Equals(nome, StringComparison.OrdinalIgnoreCase));

                if (curso == null)
                {
                    Console.WriteLine($"Curso com o nome '{nome}' não encontrado.");
                    return;
                }

                Console.WriteLine($"Curso: {curso.NomeCurso}");
                Console.WriteLine($"Capacidade Máxima: {curso.CapacidadeMaxima}");
                Console.WriteLine($"Número de Participantes: {curso.Integrantes.Count}");

                if (curso.Integrantes.Count > 0)
                {
                    Console.WriteLine("Integrantes:");
                    foreach (var integrante in curso.Integrantes)
                    {
                        Console.WriteLine($"- Nome: {integrante.Nome}");
                        Console.WriteLine($"  Código: {integrante.CodigoPessoa}");
                        Console.WriteLine($"  CPF: {integrante.Cpf}");
                        Console.WriteLine($"  E-mail: {integrante.Email}");
                        Console.WriteLine($"  Telefone: {integrante.Telefone}");
                        Console.WriteLine($"Cursos Inscritos:{string.Join(", ", integrante.CursosInscritos)}");
                        Console.WriteLine();

                        if (integrante is Professor professor)
                        {
                            Console.WriteLine($"  Formação: {professor.Formacao}");
                            Console.WriteLine($"  Salário: {professor.Salario:C}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum integrante inscrito.");
                }

                Console.WriteLine(new string('-', 40));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exibir o curso: {ex.Message}");
            }
        }

        public void AdicionarCursoOnline(string nome, int capacidadeMaxima, string urlAula)
        {
            try
            {
                if (cursoBaseList.Exists(c => c.NomeCurso.Equals(nome, StringComparison.OrdinalIgnoreCase)))
                    throw new ExcecaoCurso.CursoJaCadastrado(nome);

                var cursoOnline = new CursoOnline(nome, capacidadeMaxima, urlAula);
                cursoBaseList.Add(cursoOnline);
                Data.SalvarDados(cursoBaseList);
            }
            catch (ExcecaoCurso.CursoJaCadastrado ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar curso online: {ex.Message}");
            }
        }

        public void AdicionarCursoPresencial(string nome, int capacidadeMaxima, string local_aula)
        {
            try
            {
                if (cursoBaseList.Exists(c => c.NomeCurso.Equals(nome, StringComparison.OrdinalIgnoreCase)))
                    throw new ExcecaoCurso.CursoJaCadastrado(nome);

                var cursoPresencial = new CursoPresencial(nome, capacidadeMaxima, local_aula);
                cursoBaseList.Add(cursoPresencial);
                Data.SalvarDados(cursoBaseList);
            }
            catch (ExcecaoCurso.CursoJaCadastrado ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar curso presencial: {ex.Message}");
            }
        }
        public void AdicionarCursoEspecial(string nome, int capacidadeMaxima, string local_aula, string urlAula)
        {
            try
            {
                if (cursoBaseList.Exists(c => c.NomeCurso.Equals(nome)))
                    throw new ExcecaoCurso.CursoJaCadastrado(nome);

                var cursoEspecial = new CursoEspecial(nome, capacidadeMaxima, urlAula, local_aula);
                cursoBaseList.Add(cursoEspecial);
                Data.SalvarDados(cursoBaseList);
            }
            catch (ExcecaoCurso.CursoJaCadastrado ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar curso presencial: {ex.Message}");
            }
        }

        public void AdicionarIntegrante(string nomeCurso, int codigo)
        {
            try
            {
                var pessoa = _pessoas.GetPessoa(codigo);
                if (pessoa == null)
                    throw new KeyNotFoundException("Pessoa não encontrada.");

                var curso = cursoBaseList.Find(c => c.NomeCurso.Equals(nomeCurso));
                if (curso == null)
                    throw new ExcecaoCurso.CursoNaoEncontrado(nomeCurso);

                if (curso.Integrantes.Contains(pessoa))
                    throw new ExcecaoCurso.PessoaCadastrada(pessoa.Nome);

                curso.AdicionarPessoa(pessoa);
                pessoa.CursosInscritos.Add(curso.NomeCurso);

                Data_Pessoa.SalvarDados(_pessoas.listPessoas);
                Data.SalvarDados(cursoBaseList);

                Console.WriteLine($"Integrante {pessoa.Nome} adicionado ao curso {curso.NomeCurso}.");
            }
            catch (ExcecaoCurso.CursoNaoEncontrado ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (ExcecaoCurso.PessoaCadastrada ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao adicionar integrante ao curso: {ex.Message}");
            }
        }

        public void RemoverParticipante(int codigoPessoa, string nomeCurso)
        {
            try
            {
                var pessoa = _pessoas.GetPessoa(codigoPessoa);
                if (pessoa == null)
                    throw new ExcecaoPessoa.PessoaNaoEncontrada(codigoPessoa);

                var curso = cursoBaseList.FirstOrDefault(c => c.NomeCurso == nomeCurso);

                if (curso == null)
                {
                    throw new ExcecaoCurso.CursoNaoEncontrado(nomeCurso);
                }

                if (curso.Integrantes.Contains(pessoa))
                {
                    curso.Integrantes.Remove(pessoa);
                    Console.WriteLine($"Participante {pessoa.Nome} removido com sucesso do curso {nomeCurso}.");
                }
                else
                {
                    Console.WriteLine($"A pessoa {pessoa.Nome} não está inscrita no curso {nomeCurso}.");
                }


                Data.SalvarDados(cursoBaseList);
            }
            catch (ExcecaoPessoa.PessoaNaoEncontrada ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (ExcecaoCurso.CursoNaoEncontrado ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao remover participante do curso: {ex.Message}");
            }
        }

        public void RemoverCurso(string nomeCurso)
        {
            try
            {
                var curso = cursoBaseList.Find(c => c.NomeCurso.Equals(nomeCurso));
                if (curso == null)
                    throw new ExcecaoCurso.CursoNaoEncontrado(nomeCurso);
                cursoBaseList.Remove(curso);
            }
            catch (ExcecaoCurso.CursoNaoEncontrado ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
