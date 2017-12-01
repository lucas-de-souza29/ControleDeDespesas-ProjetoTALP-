namespace ProjetoTALP_ControleDespesas
{
    partial class FormInicializacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicializacao));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTituloControleDespesa = new System.Windows.Forms.Label();
            this.progressBarTelaInicialDespesa = new System.Windows.Forms.ProgressBar();
            this.lblTituloInicializando = new System.Windows.Forms.Label();
            this.timerDespesa = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoTALP_ControleDespesas.Properties.Resources.DespesaTelaInicial;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTituloControleDespesa
            // 
            this.lblTituloControleDespesa.AutoSize = true;
            this.lblTituloControleDespesa.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloControleDespesa.Location = new System.Drawing.Point(29, 32);
            this.lblTituloControleDespesa.Name = "lblTituloControleDespesa";
            this.lblTituloControleDespesa.Size = new System.Drawing.Size(261, 27);
            this.lblTituloControleDespesa.TabIndex = 1;
            this.lblTituloControleDespesa.Text = "Controle de Despesas";
            // 
            // progressBarTelaInicialDespesa
            // 
            this.progressBarTelaInicialDespesa.Location = new System.Drawing.Point(12, 330);
            this.progressBarTelaInicialDespesa.Name = "progressBarTelaInicialDespesa";
            this.progressBarTelaInicialDespesa.Size = new System.Drawing.Size(616, 23);
            this.progressBarTelaInicialDespesa.TabIndex = 2;
            // 
            // lblTituloInicializando
            // 
            this.lblTituloInicializando.AutoSize = true;
            this.lblTituloInicializando.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInicializando.Location = new System.Drawing.Point(238, 368);
            this.lblTituloInicializando.Name = "lblTituloInicializando";
            this.lblTituloInicializando.Size = new System.Drawing.Size(194, 27);
            this.lblTituloInicializando.TabIndex = 3;
            this.lblTituloInicializando.Text = "Inicializando...";
            // 
            // timerDespesa
            // 
            this.timerDespesa.Enabled = true;
            this.timerDespesa.Tick += new System.EventHandler(this.timerDespesa_Tick);
            // 
            // FormInicializacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 404);
            this.Controls.Add(this.lblTituloInicializando);
            this.Controls.Add(this.progressBarTelaInicialDespesa);
            this.Controls.Add(this.lblTituloControleDespesa);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInicializacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTituloControleDespesa;
        private System.Windows.Forms.ProgressBar progressBarTelaInicialDespesa;
        private System.Windows.Forms.Label lblTituloInicializando;
        private System.Windows.Forms.Timer timerDespesa;
    }
}