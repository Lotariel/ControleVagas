using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleVagas.Controle;
using ControleVagas.Modelo;

namespace ControleVagas.Visao
{
    public partial class Cadastro_Plataforma : Form
    {
        private ControleVagas_Control controlevagas_Controle = new ControleVagas_Control();
        
        public Cadastro_Plataforma()
        {
            InitializeComponent();
        }

        private void BTN_salvar_Click(object sender, EventArgs e)
        {
            Gravar_Plataforma();
        }
        private void Gravar_Plataforma()
        {
            try
            {
                controlevagas_Controle.Gravar_Tabela_Plataforma(TXT_nome_plataforma.Text);
                MessageBox.Show("Cadastro realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Plataforma já cadastrada."))
                {
                    MessageBox.Show("Plataforma já cadastrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao carregar o Modelo [ControleVagas]\r\nMotivo: " + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
}
