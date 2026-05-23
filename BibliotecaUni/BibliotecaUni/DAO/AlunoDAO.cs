using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 
using BibliotecaUni.Mapeamento;

namespace BibliotecaUni.DAO
{
    public class AlunoDAO
    {
        
        public void Inserir(Aluno aluno)
        {
            
            using (SqlConnection conn = Conexao.GetConexao())
            {
                
                string sql = @"INSERT INTO Alunos (nome, matricula, email, telefone) 
                               VALUES (@nome, @matricula, @email, @telefone)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@nome", aluno.Nome);
                    cmd.Parameters.AddWithValue("@matricula", aluno.Matricula);
                    cmd.Parameters.AddWithValue("@email", aluno.Email);
                    cmd.Parameters.AddWithValue("@telefone", aluno.Telefone);

                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public DataTable BuscarPorNome(string nome)
        {
            DataTable tabela = new DataTable();

            using (SqlConnection conn = Conexao.GetConexao())
            {
                
                string sql = @"SELECT 
                        A.nome AS 'Nome Aluno', 
                        A.matricula AS 'Matrícula', 
                        A.telefone AS 'Telefone',
                        L.titulo AS 'Livro Emprestado',
                        E.data_devolucao_prevista AS 'Prazo Devolução',
                        E.status AS 'Estado'
                       FROM Alunos A
                       LEFT JOIN Emprestimos E ON A.id_aluno = E.id_aluno
                       LEFT JOIN Livros L ON E.id_livro = L.id_livro
                       WHERE A.nome LIKE @nome";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    conn.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabela);
                    }
                }
            }

            return tabela;
        }


        public DataTable Pesquisar(string nome)
        {
            
            DataTable tabela = new DataTable();

            using (SqlConnection conn = Conexao.GetConexao())
            {
               
                string sql = @"SELECT nome AS 'Nome', matricula AS 'Matrícula', email AS 'E-mail', telefone AS 'Telefone' 
                               FROM Alunos 
                               WHERE nome LIKE @nome";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                  
                    cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    conn.Open();

                    
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(tabela);
                    }
                }
            }

            return tabela; 
        }
    }
}