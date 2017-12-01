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


namespace ProjetoTALP_ControleDespesas.ConsultaDespesas
{
    public partial class FormConsultaDespesa : Form
    {
        public FormConsultaDespesa()
        {
            InitializeComponent();
            //Busca e mostra o nome do usuário logado de acordo com o banco de dados criado no sqlServer.
            lblLogado.Text = SistemaLogado.UsuarioLogado.Nome;
        }
        /// <summary>
        /// Método para ver todos os dados da tabela Despesas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerDados_Click(object sender, EventArgs e)
        {
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoDespesas"].ToString();
            SqlConnection conecta = new SqlConnection(conn);
            try
            {
                conecta.Open();
                var sqlConecta = "SELECT * FROM Despesas";
                SqlCommand comando = new SqlCommand(sqlConecta, conecta);
                comando.CommandType = CommandType.Text;

                DataSet dtSet = new DataSet();
                SqlDataAdapter dtAdapter = new SqlDataAdapter(comando);

                dtAdapter.Fill(dtSet);
                this.dtGridViewDespesas.DataSource = dtSet.Tables[0];
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                conecta.Close();
            }
        }
    }
}
