using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjetoTALP_ControleDespesas.Classes;

namespace ProjetoTALP_ControleDespesas.ConsultaDespesa
{
    public partial class FormConsultaDespesaPorId : Form
    {
        static SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoDespesas"].ToString());
        public FormConsultaDespesaPorId()
        {
            InitializeComponent();
            //Chama o método carregarGrid
            carregarGrid();
        }
        /// <summary>
        /// Método para carregar o gridView dos dados da tabela Despesas.
        /// </summary>
        private void carregarGrid()
        {
            try
            {
                con.Open();
                var sql = "SELECT IdDespesas,TipoDespesa,Valor,Descricao FROM Despesas ORDER BY IdDespesas";

                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = System.Data.CommandType.Text;

                DataSet dt = new System.Data.DataSet();
                SqlDataAdapter dtAdapter = new SqlDataAdapter(comando);
                dtAdapter.Fill(dt);

                this.dtGridViewConsultaPorId.DataSource = dt.Tables[0];

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// Método para buscar despesa pelo ID
        /// </summary>
        private void buscarDespesaPorID()
        {
            string conexao = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoDespesas"].ToString();
            SqlConnection con = new SqlConnection(conexao);
            try
            {
                con.Open();
                var sql = "SELECT IdDespesas,TipoDespesa,Valor,Descricao FROM Despesas WHERE IdDespesas like'%" + txtIdConsulta.Text + "%'";
                SqlCommand comando = new SqlCommand(sql, con);
                comando.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable despesas = new DataTable();
                adapter.Fill(despesas);
                // atribui o dataTable ao dtGridViewBuscaNomeDespesa para exibir o resultado.
                dtGridViewConsultaPorId.DataSource = despesas;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// Método para chamar outro método chamado buscarDespesaPorID.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIdConsulta_TextChanged(object sender, EventArgs e)
        {
            buscarDespesaPorID();
        }
    }
}
