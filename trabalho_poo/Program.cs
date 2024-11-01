



using trabalho_poo.Data_arquivo;
using trabalho_poo.Models;
using trabalho_poo.Models.Cursos;

public class Program
{
    public static void Main(string[] args)
    {
        List<CursoBase> cursos = Data.CarregarDados();
        foreach (var curso in cursos)
        {
          curso.ExibirInformações();
        }

        //var curso1 = new CursoBase("Filosofia", 20);
        //var curso2 = new CursoBase("Ingles", 20);

        //cursos.Add(curso1);
        //cursos.Add(curso2);

      Data.SalvarDados(cursos);
    }
}