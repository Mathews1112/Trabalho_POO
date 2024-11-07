using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using trabalho_poo.Models.Cursos;

namespace trabalho_poo.Data_arquivo
{
    internal class Data
    {
        private static readonly string caminhoDoArquivo = "E:\\#Trabalho_POO\\Trabalho_POO\\trabalho_poo\\cursos.json";

        public static void SalvarDados(List<CursoBase> cursoBase) { 
            
            var opcoes = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(cursoBase.Cast<Object>().ToList(), opcoes);
            File.WriteAllText(caminhoDoArquivo, json);
            Console.WriteLine("Dados salvos com sucesso");

        }
        public static List<CursoBase> CarregarDados()
        {
            string json = File.ReadAllText(caminhoDoArquivo);
            Console.WriteLine(json);
            return JsonSerializer.Deserialize<List<CursoBase>>(json);
        }
    }
}
