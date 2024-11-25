using System;

namespace trabalho_poo.Excecoes
{
    internal class ExcecaoCurso : Exception
    {
        public class CapacidadeExcedida : InvalidOperationException
        {
            public CapacidadeExcedida() : base("Número de alunos excedido.") { }
        }

        public class PessoaCadastrada : InvalidOperationException
        {
            public PessoaCadastrada(string nome) : base($"Aluno {nome} já está cadastrado no curso.") { }
        }

        public class CursoJaCadastrado : InvalidOperationException
        {
            public CursoJaCadastrado(string nome) : base($"O curso '{nome}' já está cadastrado.") { }
        }

        public class CursoNaoEncontrado : KeyNotFoundException
        {
            public CursoNaoEncontrado(string nome) : base($"Curso '{nome}' não encontrado.") { }
        }
    }
}
