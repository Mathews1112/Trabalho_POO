using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trabalho_poo.Data_arquivo;
using trabalho_poo.Models;
using trabalho_poo.Models.Cursos;

namespace trabalho_poo.Controllers
{
    internal class CursoController
    {
        private List<CursoBase> cursoBaseList;
        PessoaController _pessoas;
        public CursoController (PessoaController pessoaController)
        {
            _pessoas = pessoaController;
            cursoBaseList = Data.CarregarDados();
        }
        public void ExibirListaCursos() {

            foreach (var c in cursoBaseList)
            {
                Console.WriteLine(c.NomeCurso);
            }
        }
        public void ExibirInformacao(string nome)
        {
            foreach (var c in cursoBaseList)
            {
                if ( c.NomeCurso.ToLower() == nome.ToLower())
                    c.ExibirInformações();
       

            }
        }
        public void AdicionarCursoOnline (string nome, int capacidadeMaxima)
        {
            CursoBase cursoOnline = new CursoOnline(nome, capacidadeMaxima);
            cursoBaseList.Add(cursoOnline);
            Data.SalvarDados(cursoBaseList);
        }
        public void AdicionarCursoPresencial(string nome, int capacidadeMaxima)
        {
            CursoBase cursoPresencial = new CursoPresencial(nome, capacidadeMaxima);
            cursoBaseList.Add(cursoPresencial);
            Data.SalvarDados(cursoBaseList);
        }
        public void AdicionarCursoEspecial(string nome, int capacidade)
        {
            CursoBase curso = new CursoEspecial(nome, capacidade);
            cursoBaseList.Add(curso);
            Data.SalvarDados(cursoBaseList);
        }
        public void RemoverCurso(CursoBase curso) { 
            cursoBaseList.Remove(curso);
            Data.SalvarDados(cursoBaseList);
        }
        public void AdicionarIntegrante(string nomeCurso, int codigo)
        {
            var pessoa = _pessoas.GetPessoa(codigo);
            Console.WriteLine(pessoa.Nome);
            foreach(var curso in cursoBaseList)
            {
                if(curso.NomeCurso.ToLower() == nomeCurso.ToLower())
                {
                    curso.AdicionarPessoa(pessoa);
                    pessoa.CursosInscritos.Add(curso.NomeCurso);
                    Console.WriteLine($"Curso:{curso.NomeCurso}");
                    Data_Pessoa.SalvarDados(_pessoas.listPessoas);
                    break;
                }
            }
            Data.SalvarDados(cursoBaseList);
        }

        public void RemoverParticipante(Pessoa pessoa, string nomeCurso)
        {
            foreach(var curso in cursoBaseList)
            {
                if( curso.NomeCurso.ToLower() == nomeCurso.ToLower())
                {
                    curso.Integrantes.Remove(pessoa);
                }
            }
            Data.SalvarDados(cursoBaseList);
        }

    }
}
