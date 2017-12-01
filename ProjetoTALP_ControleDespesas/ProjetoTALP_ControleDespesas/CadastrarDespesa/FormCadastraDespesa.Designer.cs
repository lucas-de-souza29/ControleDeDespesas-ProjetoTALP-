namespace ProjetoTALP_ControleDespesas.CadastrarDespesa
{
    partial class FormCadastraDespesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastraDespesa));
            this.lblCadastroDespesa = new System.Windows.Forms.Label();
            this.lblTituloData = new System.Windows.Forms.Label();
            this.lblDataSistema = new System.Windows.Forms.Label();
            this.HoraAtual = new System.Windows.Forms.Timer(this.components);
            this.lblHoraAtual = new System.Windows.Forms.Label();
            this.lblTituloHr = new System.Windows.Forms.Label();
            this.lblTipoDespesa = new System.Windows.Forms.Label();
            this.lblValorDespesa = new System.Windows.Forms.Label();
            this.lblDescricaoDespesa = new System.Windows.Forms.Label();
            this.txtTipoDespesa = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCadastroDespesa
            // 
            this.lblCadastroDespesa.AutoSize = true;
            this.lblCadastroDespesa.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroDespesa.Location = new System.Drawing.Point(329, 19);
            this.lblCadastroDespesa.Name = "lblCadastroDespesa";
            this.lblCadastroDespesa.Size = new System.Drawing.Size(176, 19);
            this.lblCadastroDespesa.TabIndex = 0;
            this.lblCadastroDespesa.Text = "Cadastro - Despesas";
            // 
            // lblTituloData
            // 
            this.lblTituloData.AutoSize = true;
            this.lblTituloData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloData.Location = new System.Drawing.Point(32, 346);
            this.lblTituloData.Name = "lblTituloData";
            this.lblTituloData.Size = new System.Drawing.Size(46, 13);
            this.lblTituloData.TabIndex = 1;
            this.lblTituloData.Text = "Data : ";
            // 
            // lblDataSistema
            // 
            this.lblDataSistema.AutoSize = true;
            this.lblDataSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSistema.Location = new System.Drawing.Point(84, 346);
            this.lblDataSistema.Name = "lblDataSistema";
            this.lblDataSistema.Size = new System.Drawing.Size(78, 13);
            this.lblDataSistema.TabIndex = 2;
            this.lblDataSistema.Text = "DataSistema";
            // 
            // HoraAtual
            // 
            this.HoraAtual.Enabled = true;
            this.HoraAtual.Interval = 1000;
            this.HoraAtual.Tick += new System.EventHandler(this.HoraAtual_Tick);
            // 
            // lblHoraAtual
            // 
            this.lblHoraAtual.AutoSize = true;
            this.lblHoraAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraAtual.Location = new System.Drawing.Point(117, 389);
            this.lblHoraAtual.Name = "lblHoraAtual";
            this.lblHoraAtual.Size = new System.Drawing.Size(34, 13);
            this.lblHoraAtual.TabIndex = 3;
            this.lblHoraAtual.Text = "Hora";
            // 
            // lblTituloHr
            // 
            this.lblTituloHr.AutoSize = true;
            this.lblTituloHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloHr.Location = new System.Drawing.Point(32, 389);
            this.lblTituloHr.Name = "lblTituloHr";
            this.lblTituloHr.Size = new System.Drawing.Size(67, 13);
            this.lblTituloHr.TabIndex = 4;
            this.lblTituloHr.Text = "Hora Atual";
            // 
            // lblTipoDespesa
            // 
            this.lblTipoDespesa.AutoSize = true;
            this.lblTipoDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDespesa.Location = new System.Drawing.Point(30, 64);
            this.lblTipoDespesa.Name = "lblTipoDespesa";
            this.lblTipoDespesa.Size = new System.Drawing.Size(32, 13);
            this.lblTipoDespesa.TabIndex = 5;
            this.lblTipoDespesa.Text = "Tipo";
            // 
            // lblValorDespesa
            // 
            this.lblValorDespesa.AutoSize = true;
            this.lblValorDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDespesa.Location = new System.Drawing.Point(30, 135);
            this.lblValorDespesa.Name = "lblValorDespesa";
            this.lblValorDespesa.Size = new System.Drawing.Size(64, 13);
            this.lblValorDespesa.TabIndex = 6;
            this.lblValorDespesa.Text = "Valor (R$)";
            // 
            // lblDescricaoDespesa
            // 
            this.lblDescricaoDespesa.AutoSize = true;
            this.lblDescricaoDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoDespesa.Location = new System.Drawing.Point(30, 208);
            this.lblDescricaoDespesa.Name = "lblDescricaoDespesa";
            this.lblDescricaoDespesa.Size = new System.Drawing.Size(64, 13);
            this.lblDescricaoDespesa.TabIndex = 7;
            this.lblDescricaoDespesa.Text = "Descrição";
            // 
            // txtTipoDespesa
            // 
            this.txtTipoDespesa.Location = new System.Drawing.Point(32, 95);
            this.txtTipoDespesa.Name = "txtTipoDespesa";
            this.txtTipoDespesa.Size = new System.Drawing.Size(171, 20);
            this.txtTipoDespesa.TabIndex = 8;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(76, 280);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(33, 166);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(170, 20);
            this.txtValor.TabIndex = 12;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(32, 234);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(171, 20);
            this.txtDescricao.TabIndex = 13;
            // 
            // FormCadastraDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoTALP_ControleDespesas.Properties.Resources.DespesaCasa;
            this.ClientSize = new System.Drawing.Size(811, 411);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtTipoDespesa);
            this.Controls.Add(this.lblDescricaoDespesa);
            this.Controls.Add(this.lblValorDespesa);
            this.Controls.Add(this.lblTipoDespesa);
            this.Controls.Add(this.lblTituloHr);
            this.Controls.Add(this.lblHoraAtual);
            this.Controls.Add(this.lblDataSistema);
            this.Controls.Add(this.lblTituloData);
            this.Controls.Add(this.lblCadastroDespesa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastraDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar - Despesas";
            this.Load += new System.EventHandler(this.FormCadastraDespesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadastroDespesa;
        private System.Windows.Forms.Label lblTituloData;
        private System.Windows.Forms.Label lblDataSistema;
        private System.Windows.Forms.Timer HoraAtual;
        private System.Windows.Forms.Label lblHoraAtual;
        private System.Windows.Forms.Label lblTituloHr;
        private System.Windows.Forms.Label lblTipoDespesa;
        private System.Windows.Forms.Label lblValorDespesa;
        private System.Windows.Forms.Label lblDescricaoDespesa;
        private System.Windows.Forms.TextBox txtTipoDespesa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}