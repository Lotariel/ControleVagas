using aula_fabricio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aula_fabricio
{
    public partial class cadastro : System.Web.UI.Page
    {
        Conexao conexao = new Conexao();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool validar = conexao.select_pessoa(txt_email.Text);

            if (validar == true)
            {
                
            }
        }
    }
}