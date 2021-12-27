using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ControleVagas.Modelo;
using System.Data;

namespace ControleVagas.Dados
{
    public class ControleVaga_Dados : Conexao
    {
        private string Script = "";

        public void Gravar_No_Banco(ControleVaga_Model controleVaga)
        {
            try
            {
                if (Verificar_Duplicidade_ControleVaga(controleVaga) == 0)
                {
                    Script = "Insert into Controle_Vagas ";
                    Script += "(Titulo_Vaga,Empresa,meio_inscricao,data_inscricao,observacao,link_vaga) ";
                    Script += "Values(";
                    Script += "'" + controleVaga.TituloVaga + "',";
                    Script += "'" + controleVaga.Empresa + "',";
                    Script += "'" + controleVaga.MeioInscricao + "',";
                    Script += "'" + controleVaga.DataInicio + "',";
                    Script += "'" + controleVaga.Observacao + "',";
                    Script += "'" + controleVaga.LinkVaga + "')";

                    SqlCommand insert = new SqlCommand(Script, ConectaraoBanco());
                    insert.ExecuteScalar();
                    FecharConexao();
                }
                else
                {
                    throw new Exception("Vaga já cadastra no sistema.");
                }

                
            }
            catch (Exception ex)
            {
                throw new Exception("Insert não executada na tabela Controle Vendas.\r\n" + ex.Message);
            }

        }
        public void Gravar_Tabela_Plataforma(string Nome)
        {
            try
            {
                if (Verificar_Duplicidade_Plataforma(Nome) ==0)
                {
                    Script = "Insert into Plataforma";
                    Script += "(Nome) ";
                    Script += "Values(";
                    Script += "'" + Nome + "')";

                    SqlCommand insert = new SqlCommand(Script, ConectaraoBanco());
                    insert.ExecuteScalar();
                    FecharConexao();
                }
                else
                {
                    throw new Exception("Plataforma já cadastrada.");
                }
               
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar Insert na tabela Plataforma.\r\n" + ex.Message);
            }

        }
        public int Verificar_Duplicidade_ControleVaga(ControleVaga_Model controleVaga)
        {
            try
            {
                int valor = 0;
                
                Script = "select count(*) from controle_vagas ";
                Script += " where Empresa= '" + controleVaga.Empresa + "'";
                Script += " and titulo_vaga ='" + controleVaga.TituloVaga + "'";

                SqlCommand select = new SqlCommand(Script, ConectaraoBanco());                
                valor = Convert.ToInt32(select.ExecuteScalar());
                FecharConexao();

                return valor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public int Verificar_Duplicidade_Plataforma(string nome)
        {
            try
            {
                int valor = 0;

                Script = "select count(*) from plataforma ";
                Script += " where Nome = '" + nome + "'";                

                SqlCommand select = new SqlCommand(Script, ConectaraoBanco());
                valor = Convert.ToInt32(select.ExecuteScalar());
                FecharConexao();

                return valor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable Carregar_Grid(ControleVaga_Model controleVaga)
        {
            try
            {
                Script = "select * from controle_vagas";
                Script += " where data_inscricao >= '" + controleVaga.DataInicio + "'";
                Script += " and data_inscricao <= '" + controleVaga.DataFinal + "'";

                if (!string.IsNullOrEmpty(controleVaga.Empresa))
                {
                    Script += " and Empresa like('%" + controleVaga.Empresa + "%')";
                }

                if (!string.IsNullOrEmpty(controleVaga.TituloVaga))
                {
                    Script += " and Titulo_Vaga like('%" + controleVaga.TituloVaga + "%')";
                }

                SqlCommand select = new SqlCommand(Script, ConectaraoBanco());

                FecharConexao();

                return ObterTabela(select.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao ler tabela Controle_Vagas.\r\n" + ex.Message);
            }
        }
        public DataTable CarregarCombo()
        {
            try
            {
                Script = "select * from Plataforma";

                SqlCommand select = new SqlCommand(Script, ConectaraoBanco());

                FecharConexao();

                return ObterTabela(select.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar a tabela Plataforma.\r\n" + ex.Message);
            }

        }
        
        //Função adquirida da internet
        public DataTable ObterTabela(SqlDataReader reader)
        {//Código adiquirido do site https://www.devmedia.com.br/obtendo-um-datatable-a-partir-de-um-datareader-em-net-em-csharp-e-vb-net/25738

            DataTable tbEsquema = reader.GetSchemaTable();
            DataTable tbRetorno = new DataTable();

            foreach (DataRow r in tbEsquema.Rows)
            {
                if (!tbRetorno.Columns.Contains(r["ColumnName"].ToString()))
                {
                    DataColumn col = new DataColumn()
                    {
                        ColumnName = r["ColumnName"].ToString(),
                        Unique = Convert.ToBoolean(r["IsUnique"]),
                        AllowDBNull = Convert.ToBoolean(r["AllowDBNull"]),
                        ReadOnly = Convert.ToBoolean(r["IsReadOnly"])
                    };
                    tbRetorno.Columns.Add(col);
                }
            }

            while (reader.Read())
            {
                DataRow novaLinha = tbRetorno.NewRow();
                for (int i = 0; i < tbRetorno.Columns.Count; i++)
                {
                    novaLinha[i] = reader.GetValue(i);
                }
                tbRetorno.Rows.Add(novaLinha);
            }

            return tbRetorno;
        }
    }
}
