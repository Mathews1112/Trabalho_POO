using System;

namespace trabalho_poo.Excecoes
{
    internal class ExcecaoPessoa : Exception
    {
        public class PessoaNaoEncontrada : KeyNotFoundException
        {
            public PessoaNaoEncontrada(int codigo) : base($"Pessoa com código '{codigo}' não foi encontrada.") { }
            public PessoaNaoEncontrada(string nome) : base($"Pessoa com o nome '{nome}' não foi encontrada.") { }
        }

        public class PessoaJaCadastrada : InvalidOperationException
        {
            public PessoaJaCadastrada(string nome) : base($"Pessoa com o nome '{nome}' já está cadastrada.") { }
        }

        public class CodigoInvalido : ArgumentException
        {
            public CodigoInvalido() : base("O código gerado para a pessoa é inválido.") { }
        }
    }
}
