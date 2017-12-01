namespace ProjetoTALP_ControleDespesas.ConsultaDespesa
{
    partial class FormConsultaDespesaPorId
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaDespesaPorId));
            this.dtGridViewConsultaPorId = new System.Windows.Forms.DataGridView();
            this.lblTituloConsultaId = new System.Windows.Forms.Label();
            this.lblIdConsulta = new System.Windows.Forms.Label();
            this.txtIdConsulta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewConsultaPorId)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridViewConsultaPorId
            // 
            this.dtGridViewConsultaPorId.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewConsultaPorId.Location = new System.Drawing.Point(22, 59);
            this.dtGridViewConsultaPorId.Name = "dtGridViewConsultaPorId";
            this.dtGridViewConsultaPorId.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewConsultaPorId.Size = new System.Drawing.Size(527, 198);
            this.dtGridViewConsultaPorId.TabIndex = 0;
            // 
            // lblTituloConsultaId
            // 
            this.lblTituloConsultaId.AutoSize = true;
            this.lblTituloConsultaId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConsultaId.Location = new System.Drawing.Point(166, 18);
            this.lblTituloConsultaId.Name = "lblTituloConsultaId";
            this.lblTituloConsultaId.Size = new System.Drawing.Size(230, 22);
            this.lblTituloConsultaId.TabIndex = 3;
            this.lblTituloConsultaId.Text = "Consulta por Id - Despesas";
            // 
            // lblIdConsulta
            // 
            this.lblIdConsulta.AutoSize = true;
            this.lblIdConsulta.Location = new System.Drawing.Point(19, 311);
            this.lblIdConsulta.Name = "lblIdConsulta";
            this.lblIdConsulta.Size = new System.Drawing.Size(16, 13);
            this.lblIdConsulta.TabIndex = 4;
            this.lblIdConsulta.Text = "Id";
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.Location = new System.Drawing.Point(41, 311);
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(143, 20);
            this.txtIdConsulta.TabIndex = 5;
            this.txtIdConsulta.TextChanged += new System.EventHandler(this.txtIdConsulta_TextChanged);
            // 
            // FormConsultaDespesaPorId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 418);
            this.Controls.Add(this.txtIdConsulta);
            this.Controls.Add(this.lblIdConsulta);
            this.Controls.Add(this.lblTituloConsultaId);
            this.Controls.Add(this.dtGridViewConsultaPorId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultaDespesaPorId";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Por ID";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewConsultaPorId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewConsultaPorId;
        private System.Windows.Forms.Label lblTituloConsultaId;
        private System.Windows.Forms.Label lblIdConsulta;
        private System.Windows.Forms.TextBox txtIdConsulta;
    }
}