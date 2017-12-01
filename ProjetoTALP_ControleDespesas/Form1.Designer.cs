namespace ProjetoTALP_ControleDespesas
{
    partial class FormControleDespesas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControleDespesas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsuarioLogado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.visualizarToolStripMenuItem,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despesasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.excluirToolStripMenuItem});
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.despesasToolStripMenuItem.Text = "Despesas";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despesasToolStripMenuItem1,
            this.iDToolStripMenuItem,
            this.nomeToolStripMenuItem});
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // despesasToolStripMenuItem1
            // 
            this.despesasToolStripMenuItem1.Name = "despesasToolStripMenuItem1";
            this.despesasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.despesasToolStripMenuItem1.Text = "Despesas";
            this.despesasToolStripMenuItem1.Click += new System.EventHandler(this.despesasToolStripMenuItem1_Click);
            // 
            // iDToolStripMenuItem
            // 
            this.iDToolStripMenuItem.Name = "iDToolStripMenuItem";
            this.iDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iDToolStripMenuItem.Text = "ID";
            this.iDToolStripMenuItem.Click += new System.EventHandler(this.iDToolStripMenuItem_Click);
            // 
            // nomeToolStripMenuItem
            // 
            this.nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            this.nomeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nomeToolStripMenuItem.Text = "Nome";
            this.nomeToolStripMenuItem.Click += new System.EventHandler(this.nomeToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // lblUsuarioLogado
            // 
            this.lblUsuarioLogado.AutoSize = true;
            this.lblUsuarioLogado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogado.Location = new System.Drawing.Point(516, 5);
            this.lblUsuarioLogado.Name = "lblUsuarioLogado";
            this.lblUsuarioLogado.Size = new System.Drawing.Size(61, 19);
            this.lblUsuarioLogado.TabIndex = 1;
            this.lblUsuarioLogado.Text = "Usuario";
            // 
            // FormControleDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoTALP_ControleDespesas.Properties.Resources.Despesas;
            this.ClientSize = new System.Drawing.Size(601, 375);
            this.Controls.Add(this.lblUsuarioLogado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormControleDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle - Despesas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Label lblUsuarioLogado;
        private System.Windows.Forms.ToolStripMenuItem iDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomeToolStripMenuItem;
    }
}

