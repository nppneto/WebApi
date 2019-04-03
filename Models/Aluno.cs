using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp2.Models
{
    public class Aluno
    {
        
        public int id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string telefone { get; set; }
        public int ra { get; set; }


        public List<Aluno> listaAlunos()
        {

            var caminhoArquivo = @"~Base.json";


        }
    }
}