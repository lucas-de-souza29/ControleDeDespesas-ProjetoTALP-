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


namespace ProjetoTALP_ControleDespesas.AlteraDespesa
{
    public partial class FormAlteraDespesa : Form
    {
        static SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoDespesas"].ToString());

        public FormAlteraDespesa()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método para chamar o método grid dos dados da tabela Despesas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAlteraDespesa_Load(object sender, EventArgs e)
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

                this.dtGridViewAlterarDespesa.DataSource = dt.Tables[0];

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
        /// Método para alterar dados da Tabela Despesas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlterarDespesa_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoDespesas"].ToString());
                con.Open();

                string id = dtGridViewAlterarDespesa.CurrentRow.Cells[0].Value.ToString();
                string tipo = dtGridViewAlterarDespesa.CurrentRow.Cells[1].Value.ToString();
                string valor = dtGridViewAlterarDespesa.CurrentRow.Cells[2].Value.ToString();
                string descricao = dtGridViewAlterarDespesa.CurrentRow.Cells[3].Value.ToString();

                var sqlComando = "UPDATE Despesas SET TipoDespesa = @TipoDespesa, Valor = @Valor, Descricao = @Descricao WHERE IdDespesas = @IdDespesas"; 
                SqlCommand comando = new SqlCommand(sqlComando,con);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@IdDespesas",txtId.Text);
                comando.Parameters.AddWithValue("@TipoDespesa",txtTipoDespesa.Text);
                comando.Parameters.AddWithValue("@Valor", txtValor.Text);
                comando.Parameters.AddWithValue("@Descricao", txtDescricao.Text);

                int resultado = 0;
                resultado = comando.ExecuteNonQuery();

                if (resultado == 1)
                {
                    MessageBox.Show("Despesa alterada com sucesso!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
                carregarGrid();
                con.Close();
            }

        /// <summary>
        /// Método para limpar o(s) campo(s). 
        /// </summary>
        private void limparCampos()
        {
            txtId.Text = "";
            txtTipoDespesa.Text = "";
            txtValor.Text = "";
            txtDescricao.Text = "";
        }
        /// <summary>
        /// Método para quando o usuário clicar em enter e ir para o próximo campo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
        /// <summary>
        /// Método para quando o usuário clicar em enter e ir para o próximo campo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTipoDespesa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
        /// <summary>
        /// Método para quando o usuário clicar em enter e ir para o próximo campo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
        /// <summary>
        /// Método para quando o usuário clicar em enter e ir para o próximo campo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
    }
}
