namespace ProjetoTALP_ControleDespesas.AlteraDespesa
{
    partial class FormAlteraDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlteraDespesa));
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlterarDespesa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTituloAlterar = new System.Windows.Forms.Label();
            this.dtGridViewAlterarDespesa = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTipoDespesa = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewAlterarDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            // 
            // btnAlterarDespesa
            // 
            this.btnAlterarDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDespesa.Location = new System.Drawing.Point(57, 341);
            this.btnAlterarDespesa.Name = "btnAlterarDespesa";
            this.btnAlterarDespesa.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarDespesa.TabIndex = 1;
            this.btnAlterarDespesa.Text = "Atualizar";
            this.btnAlterarDespesa.UseVisualStyleBackColor = true;
            this.btnAlterarDespesa.Click += new System.EventHandler(this.btnAlterarDespesa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descricao";
            // 
            // lblTituloAlterar
            // 
            this.lblTituloAlterar.AutoSize = true;
            this.lblTituloAlterar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAlterar.Location = new System.Drawing.Point(324, 20);
            this.lblTituloAlterar.Name = "lblTituloAlterar";
            this.lblTituloAlterar.Size = new System.Drawing.Size(161, 22);
            this.lblTituloAlterar.TabIndex = 5;
            this.lblTituloAlterar.Text = "Alterar - Despesas";
            // 
            // dtGridViewAlterarDespesa
            // 
            this.dtGridViewAlterarDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewAlterarDespesa.Location = new System.Drawing.Point(248, 89);
            this.dtGridViewAlterarDespesa.Name = "dtGridViewAlterarDespesa";
            this.dtGridViewAlterarDespesa.Size = new System.Drawing.Size(519, 215);
            this.dtGridViewAlterarDespesa.TabIndex = 8;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(23, 53);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(26, 70);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 20);
            this.txtId.TabIndex = 10;
            // 
            // txtTipoDespesa
            // 
            this.txtTipoDespesa.Location = new System.Drawing.Point(26, 142);
            this.txtTipoDespesa.Name = "txtTipoDespesa";
            this.txtTipoDespesa.Size = new System.Drawing.Size(125, 20);
            this.txtTipoDespesa.TabIndex = 11;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(26, 223);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 20);
            this.txtValor.TabIndex = 12;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(26, 301);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(125, 20);
            this.txtDescricao.TabIndex = 13;
            // 
            // FormAlteraDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoTALP_ControleDespesas.Properties.Resources.DespesaTelaAlterar;
            this.ClientSize = new System.Drawing.Size(802, 435);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtTipoDespesa);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dtGridViewAlterarDespesa);
            this.Controls.Add(this.lblTituloAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlterarDespesa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAlteraDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar - Despesas";
            this.Load += new System.EventHandler(this.FormAlteraDespesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewAlterarDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterarDespesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTituloAlterar;
        private System.Windows.Forms.DataGridView dtGridViewAlterarDespesa;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTipoDespesa;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}