namespace ControleVagas.Visao
{
    partial class Cadastro_Plataforma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_Plataforma));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_salvar = new System.Windows.Forms.Button();
            this.TXT_nome_plataforma = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome da Plataforma";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_salvar);
            this.groupBox1.Controls.Add(this.TXT_nome_plataforma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 81);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BTN_salvar
            // 
            this.BTN_salvar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_salvar.Image")));
            this.BTN_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_salvar.Location = new System.Drawing.Point(78, 52);
            this.BTN_salvar.Name = "BTN_salvar";
            this.BTN_salvar.Size = new System.Drawing.Size(65, 23);
            this.BTN_salvar.TabIndex = 16;
            this.BTN_salvar.Text = "Salvar";
            this.BTN_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_salvar.UseVisualStyleBackColor = true;
            this.BTN_salvar.Click += new System.EventHandler(this.BTN_salvar_Click);
            // 
            // TXT_nome_plataforma
            // 
            this.TXT_nome_plataforma.Location = new System.Drawing.Point(115, 13);
            this.TXT_nome_plataforma.MaxLength = 100;
            this.TXT_nome_plataforma.Name = "TXT_nome_plataforma";
            this.TXT_nome_plataforma.Size = new System.Drawing.Size(126, 20);
            this.TXT_nome_plataforma.TabIndex = 2;
            // 
            // Cadastro_Plataforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 102);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cadastro_Plataforma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Plataforma";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_nome_plataforma;
        private System.Windows.Forms.Button BTN_salvar;
    }
}