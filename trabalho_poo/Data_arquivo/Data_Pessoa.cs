using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using trabalho_poo.Models;
using trabalho_poo.Models.Cursos;

namespace trabalho_poo.Data_arquivo
{
    internal class Data_Pessoa
    {
        private static readonly string caminhoDoArquivo = "C:\\Users\\matheus.alvim\\Music\\Git_Trabalho_POO\\Trabalho_POO\\trabalho_poo\\Banco_de_dados\\pessoa.json";

        public static void SalvarDados(List<Pessoa> pessoas)
        {

            var opcoes = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(pessoas, opcoes);
            File.WriteAllText(caminhoDoArquivo, json);
            Console.WriteLine("Dados salvos com sucesso");

        }
        public static List<Pessoa> CarregarDados()
        {
            string json = File.ReadAllText(caminhoDoArquivo);
            Console.WriteLine(json);
            return JsonSerializer.Deserialize<List<Pessoa>>(json);
        }
    }
}
