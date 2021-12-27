using aula_fabricio.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aula_fabricio
{
    public partial class Default : System.Web.UI.Page
    {

        Conexao conexao = new Conexao();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Label1.Text = conexao.select_pessoa("teste").ToString();
        }
    }
}