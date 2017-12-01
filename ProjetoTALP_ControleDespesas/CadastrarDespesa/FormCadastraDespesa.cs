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

namespace ProjetoTALP_ControleDespesas.CadastrarDespesa
{
    public partial class FormCadastraDespesa : Form
    {
        public FormCadastraDespesa()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método para buscar as horas, minutos e segundos em tempo real. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoraAtual_Tick(object sender, EventArgs e)
        {
            lblHoraAtual.Text = (DateTime.Now.ToString("HH:mm:ss"));
        }
        /// <summary>
        /// Método para buscar a data do sistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
      
        private void FormCadastraDespesa_Load(object sender, EventArgs e)
        {
            string Date = DateTime.Now.ToShortDateString();
            lblDataSistema.Text = Date;
        }
        /// <summary>
        /// Método para inserir uma despesa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoDespesas"].ToString());

            try
            {
                con.Open();
                var sqlComando = "INSERT INTO Despesas VALUES (@TipoDespesa,@Valor,@Descricao)";
                SqlCommand comando = new SqlCommand(sqlComando, con);
                comando.Parameters.AddWithValue("@TipoDespesa", txtTipoDespesa.Text);
                comando.Parameters.AddWithValue("@Valor", txtValor.Text);
                comando.Parameters.AddWithValue("@Descricao", txtDescricao.Text);
  
                int resultado = 0;
                resultado = comando.ExecuteNonQuery();

                if (resultado == 1)
                {
                    MessageBox.Show("Despesa cadastrada com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar despesa!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível cadastrar despesa!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                throw ex;
              
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// Método para limpar o(s) campo(s).
        /// </summary>
        private void limparCampos()
        {
            txtTipoDespesa.Text = "";
            txtValor.Text = "";
            txtDescricao.Text = "";
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
