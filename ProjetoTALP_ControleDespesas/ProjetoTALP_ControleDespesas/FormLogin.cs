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


namespace ProjetoTALP_ControleDespesas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método para entrar no login de acordo com os dados no banco de dados feito no sqlserver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var senha = txtSenha.Text;

            string sqlcomando = "SELECT IdUsuario, Nome, Senha FROM Usuario WHERE Nome = '" + nome+"' AND Senha = '" + senha + "';";
            string conexao = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoDespesas"].ToString();
            
            //Fazendo a conexão
            SqlConnection conn = new SqlConnection(conexao);
            conn.Open();
           
            SqlCommand comando = new SqlCommand(sqlcomando,conn);
            SqlDataReader leitura = comando.ExecuteReader(); 
            Usuario user = null;
            while(leitura.Read()){
               //Lendo o id pela posição 0 na tabela Usuario
                var id = leitura[0];
                user = new Usuario();
                user.IdUsuario = (int)id;
                user.Nome = nome;
                user.Senha = senha;
            }
            if (user == null)
            {
                MessageBox.Show("Você não está cadastrado no Banco de Dados!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SistemaLogado.UsuarioLogado = user;
                FormControleDespesas f = new FormControleDespesas();
                f.ShowDialog();
            }
        }

        /// <summary>
        /// Método para quando o usuário clicar em enter e ir para o próximo campo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNome_KeyDown(object sender, KeyEventArgs e)
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
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
        /// <summary>
        /// Método para sair do login 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
