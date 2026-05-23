using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUni.DAO
{
    public class EmprestimoDAO
    {

        public void InserirPelaMatriculaEIsbn(string matricula, string isbn, DateTime dataEmprestimo, DateTime dataPrevista)
        {
            using (SqlConnection conn = Conexao.GetConexao())
            {
                
                string sql = @"INSERT INTO Emprestimos (id_aluno, id_livro, data_emprestimo, data_devolucao_prevista, status) 
                       VALUES (
                           (SELECT id_aluno FROM Alunos WHERE matricula = @matricula),
                           (SELECT id_livro FROM Livros WHERE isbn = @isbn),
                           @dataE, @dataP, 'Ativo'
                       )";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@matricula", matricula);
                    cmd.Parameters.AddWithValue("@isbn", isbn);
                    cmd.Parameters.AddWithValue("@dataE", dataEmprestimo);
                    cmd.Parameters.AddWithValue("@dataP", dataPrevista);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}