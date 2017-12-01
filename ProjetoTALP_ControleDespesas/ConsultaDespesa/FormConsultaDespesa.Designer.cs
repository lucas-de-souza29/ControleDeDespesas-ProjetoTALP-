namespace ProjetoTALP_ControleDespesas.ConsultaDespesas
{
    partial class FormConsultaDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaDespesa));
            this.dtGridViewDespesas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerDados = new System.Windows.Forms.Button();
            this.lblLogado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridViewDespesas
            // 
            this.dtGridViewDespesas.AllowUserToAddRows = false;
            this.dtGridViewDespesas.AllowUserToDeleteRows = false;
            this.dtGridViewDespesas.AllowUserToResizeColumns = false;
            this.dtGridViewDespesas.AllowUserToResizeRows = false;
            this.dtGridViewDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewDespesas.Location = new System.Drawing.Point(43, 65);
            this.dtGridViewDespesas.Name = "dtGridViewDespesas";
            this.dtGridViewDespesas.Size = new System.Drawing.Size(564, 186);
            this.dtGridViewDespesas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dados - Despesas";
            // 
            // btnVerDados
            // 
            this.btnVerDados.Location = new System.Drawing.Point(292, 267);
            this.btnVerDados.Name = "btnVerDados";
            this.btnVerDados.Size = new System.Drawing.Size(75, 29);
            this.btnVerDados.TabIndex = 2;
            this.btnVerDados.Text = "Visualizar";
            this.btnVerDados.UseVisualStyleBackColor = true;
            this.btnVerDados.Click += new System.EventHandler(this.btnVerDados_Click);
            // 
            // lblLogado
            // 
            this.lblLogado.AutoSize = true;
            this.lblLogado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogado.Location = new System.Drawing.Point(707, 9);
            this.lblLogado.Name = "lblLogado";
            this.lblLogado.Size = new System.Drawing.Size(101, 19);
            this.lblLogado.TabIndex = 3;
            this.lblLogado.Text = "NomeUsuario";
            // 
            // FormConsultaDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoTALP_ControleDespesas.Properties.Resources.Despesa;
            this.ClientSize = new System.Drawing.Size(964, 453);
            this.Controls.Add(this.lblLogado);
            this.Controls.Add(this.btnVerDados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridViewDespesas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsultaDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta - Despesas";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDespesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewDespesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerDados;
        private System.Windows.Forms.Label lblLogado;
    }
}