using ProjetoTALP_ControleDespesas.AlteraDespesa;
using ProjetoTALP_ControleDespesas.CadastrarDespesa;
using ProjetoTALP_ControleDespesas.ConsultaDespesas;
using ProjetoTALP_ControleDespesas.DeletarDadosDespesa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTALP_ControleDespesas
{
    public partial class FormControleDespesas : Form
    {
        public FormControleDespesas()
        {
            InitializeComponent();
            lblUsuarioLogado.Text = SistemaLogado.UsuarioLogado.Nome;
        }
        /// <summary>
        /// Método para sair do sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Método para sair do sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Método para cadastrar despesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastraDespesa frmCadastraDespesa = new FormCadastraDespesa();
            frmCadastraDespesa.Show();
        }
        /// <summary>
        /// Método para direcionar ao formConsultaDespesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void despesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultaDespesa frmDespesa = new FormConsultaDespesa();
            frmDespesa.Show();
        }
        /// <summary>
        /// Método para direcionar ao formExcluiDespesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExcluiDespesa frmExcluiDespesa = new FormExcluiDespesa();
            frmExcluiDespesa.Show();
        }
        /// <summary>
        /// Método para direcionar ao formAlteraDespesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlteraDespesa frmAlteraDespesa = new FormAlteraDespesa();
            frmAlteraDespesa.Show();
        }
    }
}
