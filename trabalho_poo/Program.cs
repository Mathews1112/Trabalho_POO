



using trabalho_poo.Controllers;
using trabalho_poo.Data_arquivo;
using trabalho_poo.Models;
using trabalho_poo.Models.Cursos;

public class Program
{
    public static void Main(string[] args)
    {
        //List<CursoBase> cursos = Data.CarregarDados();
        //foreach (var curso in cursos)
        //{
         // curso.ExibirInformações();
        //}

        CursoController cursoController = new CursoController();

        var curso1 = new CursoBase("Ciencias", 30);
        var curso2 = new CursoBase("Geografia", 60);

        cursoController.RemoverCurso(curso1);
        cursoController.RemoverCurso(curso2 );

        cursoController.ExibirListaCursos();
    }

}