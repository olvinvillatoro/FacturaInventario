namespace Facturacion
{
    partial class ReporteFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteFactura));
            this.dgv_reporteFactura = new System.Windows.Forms.DataGridView();
            this.nombreClienteReporte = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_totalNumero = new System.Windows.Forms.Label();
            this.lbl_nombreCliente = new System.Windows.Forms.Label();
            this.lbl_fechaFactura = new System.Windows.Forms.Label();
            this.lbl_usuarioFactura = new System.Windows.Forms.Label();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ganancia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporteFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_reporteFactura
            // 
            this.dgv_reporteFactura.AllowUserToAddRows = false;
            this.dgv_reporteFactura.AllowUserToDeleteRows = false;
            this.dgv_reporteFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reporteFactura.Location = new System.Drawing.Point(12, 95);
            this.dgv_reporteFactura.Name = "dgv_reporteFactura";
            this.dgv_reporteFactura.ReadOnly = true;
            this.dgv_reporteFactura.Size = new System.Drawing.Size(994, 326);
            this.dgv_reporteFactura.TabIndex = 0;
            // 
            // nombreClienteReporte
            // 
            this.nombreClienteReporte.AutoSize = true;
            this.nombreClienteReporte.Location = new System.Drawing.Point(12, 26);
            this.nombreClienteReporte.Name = "nombreClienteReporte";
            this.nombreClienteReporte.Size = new System.Drawing.Size(96, 13);
            this.nombreClienteReporte.TabIndex = 1;
            this.nombreClienteReporte.Text = "Nombre del Cliente";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(12, 62);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(583, 26);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "Fecha";
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(734, 441);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(59, 26);
            this.lbl_total.TabIndex = 3;
            this.lbl_total.Text = "Total";
            // 
            // lbl_totalNumero
            // 
            this.lbl_totalNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalNumero.AutoSize = true;
            this.lbl_totalNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalNumero.Location = new System.Drawing.Point(789, 435);
            this.lbl_totalNumero.Name = "lbl_totalNumero";
            this.lbl_totalNumero.Size = new System.Drawing.Size(127, 39);
            this.lbl_totalNumero.TabIndex = 3;
            this.lbl_totalNumero.Text = "L00.00";
            // 
            // lbl_nombreCliente
            // 
            this.lbl_nombreCliente.AutoSize = true;
            this.lbl_nombreCliente.Location = new System.Drawing.Point(114, 26);
            this.lbl_nombreCliente.Name = "lbl_nombreCliente";
            this.lbl_nombreCliente.Size = new System.Drawing.Size(10, 13);
            this.lbl_nombreCliente.TabIndex = 1;
            this.lbl_nombreCliente.Text = ":";
            // 
            // lbl_fechaFactura
            // 
            this.lbl_fechaFactura.AutoSize = true;
            this.lbl_fechaFactura.Location = new System.Drawing.Point(626, 26);
            this.lbl_fechaFactura.Name = "lbl_fechaFactura";
            this.lbl_fechaFactura.Size = new System.Drawing.Size(10, 13);
            this.lbl_fechaFactura.TabIndex = 1;
            this.lbl_fechaFactura.Text = ":";
            // 
            // lbl_usuarioFactura
            // 
            this.lbl_usuarioFactura.AutoSize = true;
            this.lbl_usuarioFactura.Location = new System.Drawing.Point(61, 62);
            this.lbl_usuarioFactura.Name = "lbl_usuarioFactura";
            this.lbl_usuarioFactura.Size = new System.Drawing.Size(10, 13);
            this.lbl_usuarioFactura.TabIndex = 1;
            this.lbl_usuarioFactura.Text = ":";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(12, 95);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(994, 326);
            this.axAcroPDF1.TabIndex = 4;
            this.axAcroPDF1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ganancia L";
            // 
            // lbl_ganancia
            // 
            this.lbl_ganancia.AutoSize = true;
            this.lbl_ganancia.Location = new System.Drawing.Point(645, 62);
            this.lbl_ganancia.Name = "lbl_ganancia";
            this.lbl_ganancia.Size = new System.Drawing.Size(10, 13);
            this.lbl_ganancia.TabIndex = 5;
            this.lbl_ganancia.Text = ":";
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 476);
            this.Controls.Add(this.lbl_ganancia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.lbl_totalNumero);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_usuarioFactura);
            this.Controls.Add(this.lbl_fechaFactura);
            this.Controls.Add(this.lbl_nombreCliente);
            this.Controls.Add(this.nombreClienteReporte);
            this.Controls.Add(this.dgv_reporteFactura);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteFactura";
            this.Text = "ReporteFactura";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporteFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_reporteFactura;
        private System.Windows.Forms.Label nombreClienteReporte;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_totalNumero;
        private System.Windows.Forms.Label lbl_nombreCliente;
        private System.Windows.Forms.Label lbl_fechaFactura;
        private System.Windows.Forms.Label lbl_usuarioFactura;
        public AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ganancia;
    }
}