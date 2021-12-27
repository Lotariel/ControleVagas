using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes_API;
using Newtonsoft.Json;

namespace Forms_Teste_Api
{
    public partial class Form1 : Form
    {
        API_01 api = new API_01();
        
        public Form1()
        {
            InitializeComponent();
            //Txt_resultado.Text = api.Retorno_Request();
            var json = api.Retorno_Request();

            var olinda = JsonConvert.DeserializeObject<olinda_json.Root>(json);
            Txt_resultado.Text = olinda.value[0].cotacaoCompra.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            //this.backgroundWorker1.RunWorkerAsync(2000);
            //openFileDialog1.ShowDialog(); // ABre a tela de busca de arquivo do computaor
            //string nome_arquivo = openFileDialog1.FileName; // nomeia o arquivo dentro do codigo
            //string conteudo = File.ReadAllText(nome_arquivo);//le todo conteudo do arquivo
            //DialogResult result;

            //result = MessageBox.Show("Deseja exibir somente o nome?", "ALerta", MessageBoxButtons.YesNo);

            //if (result == DialogResult.Yes)
            //{
            //    //utiliza a função deserialize do newtonSoft para pegar os campos do JSON e salvar na classe                
            //    var resposta = JsonConvert.DeserializeObject<List<Lotai_json.atributos>>(conteudo); 
            //    Txt_resultado.Text = resposta[0].Nome;
            //}
            //else
            //{
            //    Txt_resultado.Text = "Não trouxe nada";
            //}
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            MessageBox.Show("Alerta");
            
        }
    }
}
