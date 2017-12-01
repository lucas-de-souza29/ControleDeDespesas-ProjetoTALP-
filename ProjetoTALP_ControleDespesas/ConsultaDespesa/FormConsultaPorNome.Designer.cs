namespace ProjetoTALP_ControleDespesas.ConsultaDespesa
{
    partial class FormConsultaPorNome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaPorNome));
            this.dtGridViewBuscaNomeDespesa = new System.Windows.Forms.DataGridView();
            this.lblTituloConsultaPorNomeDespesa = new System.Windows.Forms.Label();
            this.lblTituloBuscaNomeDespesa = new System.Windows.Forms.Label();
            this.txtBuscaNomeDespesa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewBuscaNomeDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridViewBuscaNomeDespesa
            // 
            this.dtGridViewBuscaNomeDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewBuscaNomeDespesa.Location = new System.Drawing.Point(28, 50);
            this.dtGridViewBuscaNomeDespesa.Name = "dtGridViewBuscaNomeDespesa";
            this.dtGridViewBuscaNomeDespesa.Size = new System.Drawing.Size(464, 164);
            this.dtGridViewBuscaNomeDespesa.TabIndex = 0;
            // 
            // lblTituloConsultaPorNomeDespesa
            // 
            this.lblTituloConsultaPorNomeDespesa.AutoSize = true;
            this.lblTituloConsultaPorNomeDespesa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsultaPorNomeDespesa.Location = new System.Drawing.Point(140, 9);
            this.lblTituloConsultaPorNomeDespesa.Name = "lblTituloConsultaPorNomeDespesa";
            this.lblTituloConsultaPorNomeDespesa.Size = new System.Drawing.Size(261, 22);
            this.lblTituloConsultaPorNomeDespesa.TabIndex = 1;
            this.lblTituloConsultaPorNomeDespesa.Text = "Consulta por Nome - Despesas";
            // 
            // lblTituloBuscaNomeDespesa
            // 
            this.lblTituloBuscaNomeDespesa.AutoSize = true;
            this.lblTituloBuscaNomeDespesa.Location = new System.Drawing.Point(25, 257);
            this.lblTituloBuscaNomeDespesa.Name = "lblTituloBuscaNomeDespesa";
            this.lblTituloBuscaNomeDespesa.Size = new System.Drawing.Size(176, 13);
            this.lblTituloBuscaNomeDespesa.TabIndex = 2;
            this.lblTituloBuscaNomeDespesa.Text = "Informe o nome do tipo de despesa:";
            // 
            // txtBuscaNomeDespesa
            // 
            this.txtBuscaNomeDespesa.Location = new System.Drawing.Point(207, 254);
            this.txtBuscaNomeDespesa.Name = "txtBuscaNomeDespesa";
            this.txtBuscaNomeDespesa.Size = new System.Drawing.Size(285, 20);
            this.txtBuscaNomeDespesa.TabIndex = 3;
            this.txtBuscaNomeDespesa.TextChanged += new System.EventHandler(this.txtBuscaNomeDespesa_TextChanged);
            // 
            // FormConsultaPorNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 359);
            this.Controls.Add(this.txtBuscaNomeDespesa);
            this.Controls.Add(this.lblTituloBuscaNomeDespesa);
            this.Controls.Add(this.lblTituloConsultaPorNomeDespesa);
            this.Controls.Add(this.dtGridViewBuscaNomeDespesa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultaPorNome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Por Nome - Despesas";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewBuscaNomeDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewBuscaNomeDespesa;
        private System.Windows.Forms.Label lblTituloConsultaPorNomeDespesa;
        private System.Windows.Forms.Label lblTituloBuscaNomeDespesa;
        private System.Windows.Forms.TextBox txtBuscaNomeDespesa;
    }
}