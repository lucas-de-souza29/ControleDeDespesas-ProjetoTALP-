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


namespace ProjetoTALP_ControleDespesas.DeletarDadosDespesa
{
    /// <summary>
    /// Método para apresentar o Form e deixa a conexão de forma estática
    /// </summary>
    public partial class FormExcluiDespesa : Form
    {
        static SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoDespesas"].ToString());

        public FormExcluiDespesa()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método para chamar o método grid dos dados da tabela Despesas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormExcluiDespesa_Load(object sender, EventArgs e)
        {
            try
            {
                carregarGrid();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// Método para carregar o grid da tabela Despesas 
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

                this.dtGridViewExcluiDespesa.DataSource = dt.Tables[0];
                completarComboBox(dt.Tables[0]);
           
            }catch(Exception ex){
                
                throw ex;
            }
            finally
            {
                con.Close();
            }
           
        }


        /// <summary>
        /// Método para preencher o comboBox
        /// </summary>
        /// <param name="dt"></param>
        private void completarComboBox(DataTable dt)
        {

            this.cmbExcluiDespesa.DisplayMember = "TipoDespesa";
            this.cmbExcluiDespesa.ValueMember = "IdDespesas";
            this.cmbExcluiDespesa.DataSource = dt;
        }


        /// <summary>
        /// Método para para apresentar o valor escolhido do comboBox também para a label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbExcluiDespesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblOpcaoEscolhidaDespesa.Text = cmbExcluiDespesa.SelectedValue.ToString();
        }
        /// <summary>
        /// Método para excluir despesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExcluirDespesa_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoDespesas"].ToString());
            con.Open();

            string id = dtGridViewExcluiDespesa.CurrentRow.Cells[0].Value.ToString();
            string sql = "DELETE FROM Despesas WHERE IdDespesas = @id";

            SqlCommand comando = new SqlCommand(sql, con);
            comando.Parameters.AddWithValue("@id", id);

            int resultado = 0;

            resultado = comando.ExecuteNonQuery();
            if (resultado == 1)
            {
                MessageBox.Show("A despesa foi excluida!","Excluir",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Não foi possível excluir a despesa", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            carregarGrid(); 
            con.Close();
        }
    }
}
