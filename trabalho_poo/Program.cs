



using trabalho_poo.Models;

public class Program
{
    public static void Main(string[] args)
    {

        Professor professor = new Professor(1,"Teste1","1234","teste@gmail.com","234");

        Aluno aluno = new Aluno(1, "Teste1", "1234", "teste@gmail.com", "234");

        professor.ExibirInformações();
        Console.WriteLine();
        aluno.ExibirInformações();
    }
}