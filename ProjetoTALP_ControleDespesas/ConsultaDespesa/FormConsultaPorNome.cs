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

namespace ProjetoTALP_ControleDespesas.ConsultaDespesa
{
    public partial class FormConsultaPorNome : Form
    {
        static SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoDespesas"].ToString());
        public FormConsultaPorNome()
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

                this.dtGridViewBuscaNomeDespesa.DataSource = dt.Tables[0];

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
        /// Método para buscar por nome de acordo com o gridView da tabela Despesas.
        /// </summary>
        private void buscarPeloNome()
        {
            string conexao = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoDespesas"].ToString();
            SqlConnection con = new SqlConnection(conexao);
            try
            {
                con.Open();
                var sql = "SELECT IdDespesas,TipoDespesa,Valor,Descricao FROM Despesas WHERE TipoDespesa like'%" + txtBuscaNomeDespesa.Text + "%'";
                SqlCommand comando = new SqlCommand(sql,con);
                comando.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataTable despesas = new DataTable();
                adapter.Fill(despesas);
                // atribui o dataTable ao dtGridViewBuscaNomeDespesa para exibir o resultado.
                dtGridViewBuscaNomeDespesa.DataSource = despesas; 

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
        /// Método para buscar por nome da despesa(tipo).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBuscaNomeDespesa_TextChanged(object sender, EventArgs e)
        {
            buscarPeloNome();
        }
    }
}
