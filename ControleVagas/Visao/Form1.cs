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
using ControleVagas.Visao;

namespace ControleVagas
{
    public partial class Form1 : Form
    {
        private ControleVagas_Control controlevagas_Controle = new ControleVagas_Control();
        private ControleVaga_Model controlevagas_Modelo = new ControleVaga_Model();
        public Form1()
        {
            InitializeComponent();
            Carregar_CBO_Plataforma();
        }

        #region Eventos
        private void BTN_salvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (Validar_Campos())
            {
                Gravar_No_Banco();
            }
            
            this.Cursor = Cursors.Default;
        }
        private void btn_nova_plataforma_Click(object sender, EventArgs e)
        {
            Cadastro_Plataforma form = new Cadastro_Plataforma();
            form.ShowDialog();
        }
        private void BTN_pesquisa_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Carregar_Grid();
            this.Cursor = Cursors.Default;
        }
        private void BTN_ATUALIZAR_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Carregar_CBO_Plataforma();
            this.Cursor = Cursors.Default;
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            Limpar_Tela_Cadastro();
        }
        private void DGV_vagas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Carregar_TextBox_Da_Grid();
        }
        #endregion

        #region Funções
        private void Carregar_Modelo_ControleVagas()
        {
            try
            {
                controlevagas_Modelo.TituloVaga = TXT_vaga_cadastro.Text.Replace("'", "'");
                controlevagas_Modelo.Empresa = TXT_empresa_cadastro.Text.Replace("'", "'");
                controlevagas_Modelo.LinkVaga = txt_link.Text.Replace("'", "'");
                DateTime data = TXT_data_cadastro.Value;
                controlevagas_Modelo.DataInicio = data.ToString("dd/MM/yyyy");
                controlevagas_Modelo.Observacao = TXT_observacao.Text.Replace("'", "'");
                controlevagas_Modelo.MeioInscricao = CBO_plataforma.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o Modelo [ControleVagas]\r\nMotivo: " + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Carregar_TextBox_Da_Grid()
        {
            try
            {
                TXT_empresa_cadastro.Text = DGV_vagas.CurrentRow.Cells["empresa"].Value.ToString();
                txt_link.Text = DGV_vagas.CurrentRow.Cells["link_vaga"].Value.ToString();
                TXT_observacao.Text = DGV_vagas.CurrentRow.Cells["observacao"].Value.ToString();
                TXT_vaga_cadastro.Text = DGV_vagas.CurrentRow.Cells["titulo_vaga"].Value.ToString();
                CBO_plataforma.Text = DGV_vagas.CurrentRow.Cells["plataforma"].Value.ToString();
                txt_data_inicio.Text = DGV_vagas.CurrentRow.Cells["data"].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void Gravar_No_Banco()
        {
            try
            {
                Carregar_Modelo_ControleVagas();
                controlevagas_Controle.Gravar_No_Banco(controlevagas_Modelo);
                Limpar_Tela_Cadastro();
                MessageBox.Show("Cadastro realizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Vaga já cadastra no sistema."))
                {
                    MessageBox.Show("Vaga já cadastra!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("Erro ao salvar informações.\r\nMotivo: " + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
        private void Carregar_CBO_Plataforma()
        {
            try
            {
                CBO_plataforma.DataSource = controlevagas_Controle.CarregarCombo();
                CBO_plataforma.DisplayMember = "Nome";
                CBO_plataforma.ValueMember = "Nome";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar informações de Plataforma.\r\nMotivo: " + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Carregar_Grid()
        {
            try
            {
                controlevagas_Modelo = new ControleVaga_Model();

                controlevagas_Modelo.TituloVaga = txt_vaga_pequisa.Text;
                controlevagas_Modelo.Empresa = txt_empresa_pesquisa.Text;
                DateTime dataINI = txt_data_inicio.Value;
                controlevagas_Modelo.DataInicio = dataINI.ToString("dd/MM/yyyy");
                DateTime dataFIM = txt_data_fim.Value;
                controlevagas_Modelo.DataFinal = dataFIM.ToString("dd/MM/yyyy");
                BS_vagas.DataSource = controlevagas_Controle.Carregar_Grid(controlevagas_Modelo);
                lbl_total.Text = BS_vagas.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a Grid.\r\nMotivo: " + ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Limpar_Tela_Cadastro()
        {
            TXT_empresa_cadastro.Text = "";
            TXT_observacao.Text = "";
            txt_link.Text = "";
            TXT_vaga_cadastro.Text = "";
            CBO_plataforma.SelectedIndex = -1;
        }
        private bool Validar_Campos()
        {
            try
            {
                if (string.IsNullOrEmpty(TXT_empresa_cadastro.Text))
                {
                    TXT_empresa_cadastro.Focus();
                    throw new Exception("Informe o nome da Empresa.");
                }

                if (string.IsNullOrEmpty(TXT_vaga_cadastro.Text))
                {
                    TXT_vaga_cadastro.Focus();
                    throw new Exception("Informe o Titulo da Vaga.");
                }

                if (string.IsNullOrEmpty(CBO_plataforma.Text))
                {
                    CBO_plataforma.Focus();
                    throw new Exception("Informe uma Plataforma.");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }
        #endregion


    }
}
