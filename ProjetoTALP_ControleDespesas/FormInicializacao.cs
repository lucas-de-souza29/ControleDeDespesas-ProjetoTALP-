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
    public partial class FormInicializacao : Form
    {
        public FormInicializacao()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método para iniciar a tela do sistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDespesa_Tick(object sender, EventArgs e)
        {
            timerDespesa.Start();
            progressBarTelaInicialDespesa.Increment(1);
            if (progressBarTelaInicialDespesa.Value == 100)
            {
                timerDespesa.Stop();
                MessageBox.Show("Clique em Ok ou aperte a tecla Enter para entrar no sistema!","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                FormLogin frm = new FormLogin();
                frm.Show();
            }
        }
    }
}
