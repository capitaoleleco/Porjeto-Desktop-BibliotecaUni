using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUni.Mapeamento
{
    public class Emprestimo
    {
        public int IdEmprestimo { get; set; }
        public int IdAluno { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucaoPrevista { get; set; }
        public DateTime? DataDevolucaoReal { get; set; } 
        public string Status { get; set; }
    }
}