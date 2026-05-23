using BibliotecaUni.Mapeamento;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUni.DAO
{
    public class LivroDAO
    {
        public void Inserir(Livro livro)
        {
            // conexão 
            using (SqlConnection conn = Conexao.GetConexao())
            {
                // Escreve o comando SQL
                string sql = @"INSERT INTO Livros (titulo, autor, isbn, ano_publicacao, quantidade_total, quantidade_disponivel) 
                               VALUES (@titulo, @autor, @isbn, @ano, @qtdTotal, @qtdDisp)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    //valores 
                    cmd.Parameters.AddWithValue("@titulo", livro.Titulo);
                    cmd.Parameters.AddWithValue("@autor", livro.Autor);
                    cmd.Parameters.AddWithValue("@isbn", livro.Isbn);
                    cmd.Parameters.AddWithValue("@ano", livro.AnoPublicacao);
                    cmd.Parameters.AddWithValue("@qtdTotal", livro.QuantidadeTotal);
                    cmd.Parameters.AddWithValue("@qtdDisp", livro.QuantidadeTotal); 

                   
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarPorTitulo(string titulo)
        {
            DataTable tabela = new DataTable();

            using (SqlConnection conn = Conexao.GetConexao())
            {
                
                string sql = @"SELECT 
                        isbn AS 'ISBN', 
                        titulo AS 'Título da Obra', 
                        autor AS 'Autor(a)', 
                        ano_publicacao AS 'Ano', 
                        quantidade_total AS 'Total no Acervo', 
                        quantidade_disponivel AS 'Disponíveis'
                       FROM Livros 
                       WHERE titulo LIKE @titulo";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@titulo", "%" + titulo + "%");

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