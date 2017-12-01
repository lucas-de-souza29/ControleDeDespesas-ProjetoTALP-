namespace ProjetoTALP_ControleDespesas.DeletarDadosDespesa
{
    partial class FormExcluiDespesa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcluiDespesa));
            this.dtGridViewExcluiDespesa = new System.Windows.Forms.DataGridView();
            this.btnExcluirDespesa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbExcluiDespesa = new System.Windows.Forms.ComboBox();
            this.lblOpcaoEscolhidaDespesa = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExcluiDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridViewExcluiDespesa
            // 
            this.dtGridViewExcluiDespesa.AllowUserToAddRows = false;
            this.dtGridViewExcluiDespesa.AllowUserToDeleteRows = false;
            this.dtGridViewExcluiDespesa.AllowUserToResizeColumns = false;
            this.dtGridViewExcluiDespesa.AllowUserToResizeRows = false;
            this.dtGridViewExcluiDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewExcluiDespesa.Location = new System.Drawing.Point(25, 49);
            this.dtGridViewExcluiDespesa.Name = "dtGridViewExcluiDespesa";
            this.dtGridViewExcluiDespesa.Size = new System.Drawing.Size(537, 181);
            this.dtGridViewExcluiDespesa.TabIndex = 0;
            // 
            // btnExcluirDespesa
            // 
            this.btnExcluirDespesa.Location = new System.Drawing.Point(502, 333);
            this.btnExcluirDespesa.Name = "btnExcluirDespesa";
            this.btnExcluirDespesa.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirDespesa.TabIndex = 1;
            this.btnExcluirDespesa.Text = "Excluir";
            this.btnExcluirDespesa.UseVisualStyleBackColor = true;
            this.btnExcluirDespesa.Click += new System.EventHandler(this.btnExcluirDespesa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Excluir - Despesas";
            // 
            // cmbExcluiDespesa
            // 
            this.cmbExcluiDespesa.FormattingEnabled = true;
            this.cmbExcluiDespesa.Location = new System.Drawing.Point(25, 236);
            this.cmbExcluiDespesa.Name = "cmbExcluiDespesa";
            this.cmbExcluiDespesa.Size = new System.Drawing.Size(266, 21);
            this.cmbExcluiDespesa.TabIndex = 3;
            this.cmbExcluiDespesa.SelectedIndexChanged += new System.EventHandler(this.cmbExcluiDespesa_SelectedIndexChanged);
            // 
            // lblOpcaoEscolhidaDespesa
            // 
            this.lblOpcaoEscolhidaDespesa.AutoSize = true;
            this.lblOpcaoEscolhidaDespesa.Location = new System.Drawing.Point(315, 244);
            this.lblOpcaoEscolhidaDespesa.Name = "lblOpcaoEscolhidaDespesa";
            this.lblOpcaoEscolhidaDespesa.Size = new System.Drawing.Size(88, 13);
            this.lblOpcaoEscolhidaDespesa.TabIndex = 4;
            this.lblOpcaoEscolhidaDespesa.Text = "Opção Escolhida";
            // 
            // FormExcluiDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 373);
            this.Controls.Add(this.lblOpcaoEscolhidaDespesa);
            this.Controls.Add(this.cmbExcluiDespesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcluirDespesa);
            this.Controls.Add(this.dtGridViewExcluiDespesa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormExcluiDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir - Despesas";
            this.Load += new System.EventHandler(this.FormExcluiDespesa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewExcluiDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewExcluiDespesa;
        private System.Windows.Forms.Button btnExcluirDespesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbExcluiDespesa;
        private System.Windows.Forms.Label lblOpcaoEscolhidaDespesa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}