using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ControleVagas.Dados
{
    public class Conexao
    {
        public SqlConnection ConectaraoBanco()
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=LOTARIEL_MACHIN\LOTARIEL;Password=Lotariel;User ID=sa;Initial Catalog=Teste;Min Pool Size=5;Max Pool Size=10000;Connect Timeout=100");            
            con.Open();
            return con;
        }

        public SqlConnection FecharConexao()
        {
            SqlConnection con = new SqlConnection();            
            con.ConnectionString = @"Data Source=.\LOTARIEL;Password=Lotariel;User ID=sa;Initial Catalog=jiora;";            
            con.Close();
            return con;
        }
    }
}
