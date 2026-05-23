using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaUni.DAO
{
    public class Conexao
    {
        // conexão 
        private static string stringConexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=BibliotecaDB;Integrated Security=true;Column Encryption Setting=enabled;";

        //método conexão 
        public static SqlConnection GetConexao()
        {
            return new SqlConnection(stringConexao);
        }
    }
}