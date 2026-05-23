using BibliotecaUni.Mapeamento;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaUni.DAO
{
    public class UsuarioDAO
    {
        public Usuario Autenticar(string login, string senha)
        {
            Usuario usuario = null;

            using (SqlConnection conn = Conexao.GetConexao())
            {
                
                string sql = @"SELECT ID, Nome, Cargo, Login, AcessaCadastros, AcessaEmprestimos, Admin, Ativo 
                               FROM Usuarios 
                               WHERE Login = @login AND Senha = @senha";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                       
                        if (reader.Read())
                        {
                            usuario = new Usuario();
                            usuario.ID = Convert.ToInt32(reader["ID"]);
                            usuario.Nome = reader["Nome"].ToString();
                            usuario.Cargo = reader["Cargo"].ToString();
                            usuario.Login = reader["Login"].ToString();
                            usuario.AcessaCadastros = Convert.ToBoolean(reader["AcessaCadastros"]);
                            usuario.AcessaEmprestimos = Convert.ToBoolean(reader["AcessaEmprestimos"]);
                            usuario.Admin = Convert.ToBoolean(reader["Admin"]);
                            usuario.Ativo = Convert.ToBoolean(reader["Ativo"]);
                        }
                    }
                }
            }

            return usuario; 
        }
    }
}