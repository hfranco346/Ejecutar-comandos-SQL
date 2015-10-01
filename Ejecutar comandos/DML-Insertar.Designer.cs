namespace Ejecutar_comandos
{
    partial class DML_Insertar
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
            this.gbInsertarMonedas = new System.Windows.Forms.GroupBox();
            this.lblCodigoMoneda = new System.Windows.Forms.Label();
            this.txtCodigoMoneda = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreMoneda = new System.Windows.Forms.TextBox();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.btnInsertarMoneda = new System.Windows.Forms.Button();
            this.lblEstadoInsercion = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtpFechaModificacion = new System.Windows.Forms.DateTimePicker();
            this.gbInsertarMonedas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInsertarMonedas
            // 
            this.gbInsertarMonedas.Controls.Add(this.dtpFechaModificacion);
            this.gbInsertarMonedas.Controls.Add(this.lblEstadoInsercion);
            this.gbInsertarMonedas.Controls.Add(this.btnInsertarMoneda);
            this.gbInsertarMonedas.Controls.Add(this.lblFechaModificacion);
            this.gbInsertarMonedas.Controls.Add(this.txtNombreMoneda);
            this.gbInsertarMonedas.Controls.Add(this.lblNombre);
            this.gbInsertarMonedas.Controls.Add(this.txtCodigoMoneda);
            this.gbInsertarMonedas.Controls.Add(this.lblCodigoMoneda);
            this.gbInsertarMonedas.Location = new System.Drawing.Point(12, 12);
            this.gbInsertarMonedas.Name = "gbInsertarMonedas";
            this.gbInsertarMonedas.Size = new System.Drawing.Size(367, 237);
            this.gbInsertarMonedas.TabIndex = 0;
            this.gbInsertarMonedas.TabStop = false;
            this.gbInsertarMonedas.Text = "Insertar Moneda";
            // 
            // lblCodigoMoneda
            // 
            this.lblCodigoMoneda.AutoSize = true;
            this.lblCodigoMoneda.Location = new System.Drawing.Point(22, 37);
            this.lblCodigoMoneda.Name = "lblCodigoMoneda";
            this.lblCodigoMoneda.Size = new System.Drawing.Size(81, 13);
            this.lblCodigoMoneda.TabIndex = 0;
            this.lblCodigoMoneda.Text = "Código moneda";
            // 
            // txtCodigoMoneda
            // 
            this.txtCodigoMoneda.Location = new System.Drawing.Point(145, 34);
            this.txtCodigoMoneda.Name = "txtCodigoMoneda";
            this.txtCodigoMoneda.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMoneda.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(111, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre de la moneda";
            // 
            // txtNombreMoneda
            // 
            this.txtNombreMoneda.Location = new System.Drawing.Point(145, 65);
            this.txtNombreMoneda.Name = "txtNombreMoneda";
            this.txtNombreMoneda.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMoneda.TabIndex = 3;
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Location = new System.Drawing.Point(25, 100);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(114, 13);
            this.lblFechaModificacion.TabIndex = 4;
            this.lblFechaModificacion.Text = "Fecha de modificación";
            // 
            // btnInsertarMoneda
            // 
            this.btnInsertarMoneda.Location = new System.Drawing.Point(134, 141);
            this.btnInsertarMoneda.Name = "btnInsertarMoneda";
            this.btnInsertarMoneda.Size = new System.Drawing.Size(100, 23);
            this.btnInsertarMoneda.TabIndex = 6;
            this.btnInsertarMoneda.Text = "Insertar Moneda";
            this.btnInsertarMoneda.UseVisualStyleBackColor = true;
            this.btnInsertarMoneda.Click += new System.EventHandler(this.btnInsertarMoneda_Click);
            // 
            // lblEstadoInsercion
            // 
            this.lblEstadoInsercion.Location = new System.Drawing.Point(77, 182);
            this.lblEstadoInsercion.Name = "lblEstadoInsercion";
            this.lblEstadoInsercion.Size = new System.Drawing.Size(220, 23);
            this.lblEstadoInsercion.TabIndex = 7;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(432, 46);
            this.txtEstado.Multiline = true;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(344, 107);
            this.txtEstado.TabIndex = 1;
            // 
            // dtpFechaModificacion
            // 
            this.dtpFechaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaModificacion.Location = new System.Drawing.Point(145, 94);
            this.dtpFechaModificacion.Name = "dtpFechaModificacion";
            this.dtpFechaModificacion.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaModificacion.TabIndex = 8;
            // 
            // DML_Insertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 261);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.gbInsertarMonedas);
            this.Name = "DML_Insertar";
            this.Text = "Insertar monedas";
            this.gbInsertarMonedas.ResumeLayout(false);
            this.gbInsertarMonedas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInsertarMonedas;
        private System.Windows.Forms.Label lblEstadoInsercion;
        private System.Windows.Forms.Button btnInsertarMoneda;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.TextBox txtNombreMoneda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigoMoneda;
        private System.Windows.Forms.Label lblCodigoMoneda;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DateTimePicker dtpFechaModificacion;
    }
}