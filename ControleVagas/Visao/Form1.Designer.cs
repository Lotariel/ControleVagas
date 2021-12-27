namespace ControleVagas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.BTN_ATUALIZAR = new System.Windows.Forms.Button();
            this.btn_nova_plataforma = new System.Windows.Forms.Button();
            this.txt_link = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BTN_salvar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.TXT_observacao = new System.Windows.Forms.TextBox();
            this.TXT_vaga_cadastro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_empresa_cadastro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_data_cadastro = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.CBO_plataforma = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_data_inicio = new System.Windows.Forms.DateTimePicker();
            this.BTN_pesquisa = new System.Windows.Forms.Button();
            this.txt_vaga_pequisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_data_fim = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_empresa_pesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_vagas = new System.Windows.Forms.DataGridView();
            this.titulo_vaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataforma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link_vaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_vagas = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_vagas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_vagas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_limpar);
            this.groupBox1.Controls.Add(this.BTN_ATUALIZAR);
            this.groupBox1.Controls.Add(this.btn_nova_plataforma);
            this.groupBox1.Controls.Add(this.txt_link);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BTN_salvar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TXT_observacao);
            this.groupBox1.Controls.Add(this.TXT_vaga_cadastro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TXT_empresa_cadastro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXT_data_cadastro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CBO_plataforma);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btn_limpar
            // 
            this.btn_limpar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpar.Image")));
            this.btn_limpar.Location = new System.Drawing.Point(607, 154);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(26, 23);
            this.btn_limpar.TabIndex = 20;
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // BTN_ATUALIZAR
            // 
            this.BTN_ATUALIZAR.Image = ((System.Drawing.Image)(resources.GetObject("BTN_ATUALIZAR.Image")));
            this.BTN_ATUALIZAR.Location = new System.Drawing.Point(561, 11);
            this.BTN_ATUALIZAR.Name = "BTN_ATUALIZAR";
            this.BTN_ATUALIZAR.Size = new System.Drawing.Size(26, 23);
            this.BTN_ATUALIZAR.TabIndex = 19;
            this.BTN_ATUALIZAR.UseVisualStyleBackColor = true;
            this.BTN_ATUALIZAR.Click += new System.EventHandler(this.BTN_ATUALIZAR_Click);
            // 
            // btn_nova_plataforma
            // 
            this.btn_nova_plataforma.Image = ((System.Drawing.Image)(resources.GetObject("btn_nova_plataforma.Image")));
            this.btn_nova_plataforma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nova_plataforma.Location = new System.Drawing.Point(593, 11);
            this.btn_nova_plataforma.Name = "btn_nova_plataforma";
            this.btn_nova_plataforma.Size = new System.Drawing.Size(111, 23);
            this.btn_nova_plataforma.TabIndex = 18;
            this.btn_nova_plataforma.Text = "Nova Plataforma";
            this.btn_nova_plataforma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nova_plataforma.UseVisualStyleBackColor = true;
            this.btn_nova_plataforma.Click += new System.EventHandler(this.btn_nova_plataforma_Click);
            // 
            // txt_link
            // 
            this.txt_link.Location = new System.Drawing.Point(309, 39);
            this.txt_link.Name = "txt_link";
            this.txt_link.Size = new System.Drawing.Size(395, 20);
            this.txt_link.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Link da Vaga";
            // 
            // BTN_salvar
            // 
            this.BTN_salvar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_salvar.Image")));
            this.BTN_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_salvar.Location = new System.Drawing.Point(639, 154);
            this.BTN_salvar.Name = "BTN_salvar";
            this.BTN_salvar.Size = new System.Drawing.Size(65, 23);
            this.BTN_salvar.TabIndex = 15;
            this.BTN_salvar.Text = "Salvar";
            this.BTN_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_salvar.UseVisualStyleBackColor = true;
            this.BTN_salvar.Click += new System.EventHandler(this.BTN_salvar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Observação";
            // 
            // TXT_observacao
            // 
            this.TXT_observacao.Location = new System.Drawing.Point(10, 87);
            this.TXT_observacao.Multiline = true;
            this.TXT_observacao.Name = "TXT_observacao";
            this.TXT_observacao.Size = new System.Drawing.Size(694, 61);
            this.TXT_observacao.TabIndex = 13;
            // 
            // TXT_vaga_cadastro
            // 
            this.TXT_vaga_cadastro.Location = new System.Drawing.Point(75, 39);
            this.TXT_vaga_cadastro.MaxLength = 100;
            this.TXT_vaga_cadastro.Name = "TXT_vaga_cadastro";
            this.TXT_vaga_cadastro.Size = new System.Drawing.Size(152, 20);
            this.TXT_vaga_cadastro.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Titulo Vaga";
            // 
            // TXT_empresa_cadastro
            // 
            this.TXT_empresa_cadastro.Location = new System.Drawing.Point(75, 13);
            this.TXT_empresa_cadastro.MaxLength = 100;
            this.TXT_empresa_cadastro.Name = "TXT_empresa_cadastro";
            this.TXT_empresa_cadastro.Size = new System.Drawing.Size(152, 20);
            this.TXT_empresa_cadastro.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
            // 
            // TXT_data_cadastro
            // 
            this.TXT_data_cadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TXT_data_cadastro.Location = new System.Drawing.Point(274, 13);
            this.TXT_data_cadastro.Name = "TXT_data_cadastro";
            this.TXT_data_cadastro.Size = new System.Drawing.Size(97, 20);
            this.TXT_data_cadastro.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Plataforma";
            // 
            // CBO_plataforma
            // 
            this.CBO_plataforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBO_plataforma.FormattingEnabled = true;
            this.CBO_plataforma.Items.AddRange(new object[] {
            "Linkedin",
            "Google"});
            this.CBO_plataforma.Location = new System.Drawing.Point(436, 12);
            this.CBO_plataforma.Name = "CBO_plataforma";
            this.CBO_plataforma.Size = new System.Drawing.Size(121, 21);
            this.CBO_plataforma.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_data_inicio);
            this.groupBox2.Controls.Add(this.BTN_pesquisa);
            this.groupBox2.Controls.Add(this.txt_vaga_pequisa);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_data_fim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_empresa_pesquisa);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DGV_vagas);
            this.groupBox2.Location = new System.Drawing.Point(7, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Data";
            // 
            // txt_data_inicio
            // 
            this.txt_data_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_data_inicio.Location = new System.Drawing.Point(274, 25);
            this.txt_data_inicio.Name = "txt_data_inicio";
            this.txt_data_inicio.Size = new System.Drawing.Size(97, 20);
            this.txt_data_inicio.TabIndex = 7;
            // 
            // BTN_pesquisa
            // 
            this.BTN_pesquisa.Image = ((System.Drawing.Image)(resources.GetObject("BTN_pesquisa.Image")));
            this.BTN_pesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_pesquisa.Location = new System.Drawing.Point(626, 55);
            this.BTN_pesquisa.Name = "BTN_pesquisa";
            this.BTN_pesquisa.Size = new System.Drawing.Size(78, 27);
            this.BTN_pesquisa.TabIndex = 11;
            this.BTN_pesquisa.Text = "Pesquisar";
            this.BTN_pesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_pesquisa.UseVisualStyleBackColor = true;
            this.BTN_pesquisa.Click += new System.EventHandler(this.BTN_pesquisa_Click);
            // 
            // txt_vaga_pequisa
            // 
            this.txt_vaga_pequisa.Location = new System.Drawing.Point(75, 52);
            this.txt_vaga_pequisa.MaxLength = 100;
            this.txt_vaga_pequisa.Name = "txt_vaga_pequisa";
            this.txt_vaga_pequisa.Size = new System.Drawing.Size(152, 20);
            this.txt_vaga_pequisa.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Titulo Vaga";
            // 
            // txt_data_fim
            // 
            this.txt_data_fim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_data_fim.Location = new System.Drawing.Point(417, 26);
            this.txt_data_fim.Name = "txt_data_fim";
            this.txt_data_fim.Size = new System.Drawing.Size(97, 20);
            this.txt_data_fim.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Até";
            // 
            // txt_empresa_pesquisa
            // 
            this.txt_empresa_pesquisa.Location = new System.Drawing.Point(75, 26);
            this.txt_empresa_pesquisa.MaxLength = 100;
            this.txt_empresa_pesquisa.Name = "txt_empresa_pesquisa";
            this.txt_empresa_pesquisa.Size = new System.Drawing.Size(152, 20);
            this.txt_empresa_pesquisa.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa";
            // 
            // DGV_vagas
            // 
            this.DGV_vagas.AllowUserToAddRows = false;
            this.DGV_vagas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.DGV_vagas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_vagas.AutoGenerateColumns = false;
            this.DGV_vagas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_vagas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_vagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_vagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titulo_vaga,
            this.empresa,
            this.data,
            this.plataforma,
            this.observacao,
            this.link_vaga});
            this.DGV_vagas.DataSource = this.BS_vagas;
            this.DGV_vagas.Location = new System.Drawing.Point(6, 88);
            this.DGV_vagas.Name = "DGV_vagas";
            this.DGV_vagas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_vagas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_vagas.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGV_vagas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_vagas.Size = new System.Drawing.Size(698, 182);
            this.DGV_vagas.TabIndex = 0;
            this.DGV_vagas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_vagas_CellContentClick);
            // 
            // titulo_vaga
            // 
            this.titulo_vaga.DataPropertyName = "Titulo_Vaga";
            this.titulo_vaga.HeaderText = "Titulo da Vaga";
            this.titulo_vaga.Name = "titulo_vaga";
            this.titulo_vaga.ReadOnly = true;
            this.titulo_vaga.Width = 180;
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            this.empresa.Width = 80;
            // 
            // data
            // 
            this.data.DataPropertyName = "data_inscricao";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 80;
            // 
            // plataforma
            // 
            this.plataforma.DataPropertyName = "meio_inscricao";
            this.plataforma.HeaderText = "Plataforma";
            this.plataforma.Name = "plataforma";
            this.plataforma.ReadOnly = true;
            this.plataforma.Width = 80;
            // 
            // observacao
            // 
            this.observacao.DataPropertyName = "observacao";
            this.observacao.HeaderText = "Observação";
            this.observacao.Name = "observacao";
            this.observacao.ReadOnly = true;
            this.observacao.Width = 120;
            // 
            // link_vaga
            // 
            this.link_vaga.DataPropertyName = "link_vaga";
            this.link_vaga.HeaderText = "Link da Vaga";
            this.link_vaga.Name = "link_vaga";
            this.link_vaga.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 547);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.Controls.Add(this.lbl_total);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vagas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(653, 499);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(13, 13);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(733, 549);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vagas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_vagas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_vagas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_pesquisa;
        private System.Windows.Forms.TextBox txt_vaga_pequisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBO_plataforma;
        private System.Windows.Forms.DateTimePicker txt_data_fim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_empresa_pesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TXT_data_cadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_vagas;
        private System.Windows.Forms.TextBox txt_link;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTN_salvar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXT_observacao;
        private System.Windows.Forms.TextBox TXT_vaga_cadastro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_empresa_cadastro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txt_data_inicio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_nova_plataforma;
        private System.Windows.Forms.BindingSource BS_vagas;
        private System.Windows.Forms.Button BTN_ATUALIZAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo_vaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataforma;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn link_vaga;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label11;
    }
}

