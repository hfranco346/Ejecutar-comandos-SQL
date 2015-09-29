namespace Ejecutar_comandos
{
    partial class MetodosEscalares
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
            this.lblTotalFilas = new System.Windows.Forms.Label();
            this.txtEscalar = new System.Windows.Forms.TextBox();
            this.btnTotalFilas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotalFilas
            // 
            this.lblTotalFilas.AutoSize = true;
            this.lblTotalFilas.Location = new System.Drawing.Point(4, 35);
            this.lblTotalFilas.Name = "lblTotalFilas";
            this.lblTotalFilas.Size = new System.Drawing.Size(93, 13);
            this.lblTotalFilas.TabIndex = 0;
            this.lblTotalFilas.Text = "Total de Registros";
            // 
            // txtEscalar
            // 
            this.txtEscalar.Location = new System.Drawing.Point(105, 12);
            this.txtEscalar.Multiline = true;
            this.txtEscalar.Name = "txtEscalar";
            this.txtEscalar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEscalar.Size = new System.Drawing.Size(164, 65);
            this.txtEscalar.TabIndex = 1;
            // 
            // btnTotalFilas
            // 
            this.btnTotalFilas.Location = new System.Drawing.Point(275, 30);
            this.btnTotalFilas.Name = "btnTotalFilas";
            this.btnTotalFilas.Size = new System.Drawing.Size(108, 23);
            this.btnTotalFilas.TabIndex = 2;
            this.btnTotalFilas.Text = "Contar Registros";
            this.btnTotalFilas.UseVisualStyleBackColor = true;
            this.btnTotalFilas.Click += new System.EventHandler(this.btnTotalFilas_Click);
            // 
            // MetodosEscalares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 91);
            this.Controls.Add(this.btnTotalFilas);
            this.Controls.Add(this.txtEscalar);
            this.Controls.Add(this.lblTotalFilas);
            this.Name = "MetodosEscalares";
            this.Text = "Métodos Escalares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalFilas;
        private System.Windows.Forms.TextBox txtEscalar;
        private System.Windows.Forms.Button btnTotalFilas;
    }
}