using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;

namespace aula_fabricio.Classes
{
    public class Conexao
    {

        public SqlConnection AbrirConexao()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LOTARIEL_MACHIN\LOTARIEL;Password=Lotariel;User ID=sa;Initial Catalog=teste34;Min Pool Size=5;Max Pool Size=10000;Connect Timeout=100");
            con.Open();
            return con;
        }

        public SqlConnection FechaConexao()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LOTARIEL_MACHIN\LOTARIEL;Password=Lotariel;User ID=sa;Initial Catalog=teste34;Min Pool Size=5;Max Pool Size=10000;Connect Timeout=100");
            con.Close();
            return con;
        }


        public void insert_pessoa(string nome, string email, string telefone, string celular)
        {
                        SqlCommand update = new SqlCommand("INSERT INTO[dbo].[Pessoas]([nome],[email],[telefone],[celular]) VALUES(@nome, @email@,@telefone,@celular)", AbrirConexao());
            update.Parameters.Add(new SqlParameter("nome", nome));
            update.Parameters.Add(new SqlParameter("email", email));
            update.Parameters.Add(new SqlParameter("telefone", telefone));
            update.Parameters.Add(new SqlParameter("celular", celular));
            update.ExecuteNonQuery();
            FechaConexao();
        }

        public bool select_pessoa(string email)
        {

            SqlCommand select = new SqlCommand("select email from pessoas where email = @email", AbrirConexao());
            select.Parameters.Add(new SqlParameter("email", email));
            SqlDataReader resultado;
            resultado = select.ExecuteReader();
            resultado.Read();

            try
            {
                resultado["email"].ToString();
                return true;
            }
            catch (Exception)
            {

                return false;
            }         
        
            

        }
            
        
    }
}