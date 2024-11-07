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
        public CursoController ()
        {
            cursoBaseList = Data.CarregarDados();
        }
        public void ExibirListaCursos() {

            foreach (var c in cursoBaseList)
            {
                c.ExibirInformações();
            }
        }
        public void AdicionarCursoOnline (string nome, int capacidadeMaxima)
        {
            CursoOnline cursoOnline = new CursoOnline(nome, capacidadeMaxima);
            cursoBaseList.Add(cursoOnline);
            Data.SalvarDados(cursoBaseList);
        }
        public void AdicionarCursoPresencial(string nome, int capacidadeMaxima)
        {
            CursoPresencial cursoPresencial = new CursoPresencial(nome, capacidadeMaxima);
            cursoBaseList.Add(cursoPresencial);
            Data.SalvarDados(cursoBaseList);
        }
        public void RemoverCurso(CursoBase curso) { 
            cursoBaseList.Remove(curso);
            Data.SalvarDados(cursoBaseList);
        }
        public void AdicionarIntegrante(string nomeCurso, Pessoa pessoa)
        {

            foreach(var curso in cursoBaseList)
            {
                if(curso.NomeCurso.ToLower() == nomeCurso.ToLower())
                {
                    curso.AdicionarPessoa(pessoa);
                    Console.WriteLine($"Curso:{curso.NomeCurso}");
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
