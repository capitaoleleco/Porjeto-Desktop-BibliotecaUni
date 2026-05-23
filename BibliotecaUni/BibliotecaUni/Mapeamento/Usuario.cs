using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUni.Mapeamento
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool AcessaCadastros { get; set; }
        public bool AcessaEmprestimos { get; set; }
        public bool Admin { get; set; }
        public bool Ativo { get; set; }
    }
}
