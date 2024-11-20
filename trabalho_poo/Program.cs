



using trabalho_poo.Controllers;
using trabalho_poo.Data_arquivo;
using trabalho_poo.Models;
using trabalho_poo.Models.Cursos;

public class Program
{
    public static void Main()
    {
        //List<CursoBase> cursos = Data.CarregarDados();
        //foreach (var curso in cursos)
        //{
         // curso.ExibirInformações();
        //}

        //CursoController cursoController = new CursoController();
        
        //Pessoa pessoa = new Aluno(1,"Julio","12","julio@gmail","23");
        //Pessoa pessoa = new Aluno(2, "Maria", "13", "maria@gmail.com", "23");

        //pessoa.ExibirInformações();



        //cursoController.AdicionarIntegrante("ingles", pessoa);
        //var curso1 = new CursoBase("Ciencias", 30);
        //var curso2 = new CursoBase("Geografia", 60);

        //cursoController.ExibirListaCursos();

        PessoaController pe = new PessoaController();
        //Aluno aluno = new Aluno(1, "Julio", "12", "julio@gmail", "23");
        //pe.AdicionarPessoa(aluno);

        pe.ExibirListaPessoas();

    }

}