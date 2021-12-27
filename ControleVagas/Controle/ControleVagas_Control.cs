using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleVagas.Dados;
using ControleVagas.Modelo;
using System.Data.SqlClient;
using System.Data;

namespace ControleVagas.Controle
{
    public class ControleVagas_Control
    {
        private ControleVaga_Dados controlevagas_Dados = new ControleVaga_Dados();
        public void Gravar_No_Banco(ControleVaga_Model controleVaga)
        {
            controlevagas_Dados.Gravar_No_Banco(controleVaga);
        }
        public void Gravar_Tabela_Plataforma(string Nome)
        {
            controlevagas_Dados.Gravar_Tabela_Plataforma(Nome);
        }
        public DataTable Carregar_Grid(ControleVaga_Model controleVaga)
        {
            return controlevagas_Dados.Carregar_Grid(controleVaga);
        }
        public DataTable CarregarCombo()
        {
            return controlevagas_Dados.CarregarCombo();
        }
    }
}
