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
        public CursoController (CursoBase cursoBase)
        {
            List<CursoBase> cursos = Data.CarregarDados();
        }

        public void AdicionarCursoOnline (string nome, int capacidadeMaxima)
        {
            CursoOnline cursoOnline = new CursoOnline(nome, capacidadeMaxima);
        }
        public void AdicionarCursoPresencial(string nome, int capacidadeMaxima)
        {
            CursoPresencial cursoPresencia = new CursoPresencial(nome, capacidadeMaxima);
        }


    }
}
