namespace Facturacion
{
    partial class Abonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abonos));
            this.dgv_abono = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldotbl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ultimoAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_abono = new System.Windows.Forms.Label();
            this.txt_abono = new System.Windows.Forms.TextBox();
            this.cb_empresa = new System.Windows.Forms.ComboBox();
            this.cb_proveedor = new System.Windows.Forms.ComboBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abono)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_abono
            // 
            this.dgv_abono.AllowUserToDeleteRows = false;
            this.dgv_abono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_abono.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_abono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_abono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.empresa,
            this.saldotbl,
            this.ultimoAbono});
            this.dgv_abono.Location = new System.Drawing.Point(24, 96);
            this.dgv_abono.Name = "dgv_abono";
            this.dgv_abono.ReadOnly = true;
            this.dgv_abono.Size = new System.Drawing.Size(699, 261);
            this.dgv_abono.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "RTN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // empresa
            // 
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            // 
            // saldotbl
            // 
            this.saldotbl.HeaderText = "Saldo";
            this.saldotbl.Name = "saldotbl";
            this.saldotbl.ReadOnly = true;
            // 
            // ultimoAbono
            // 
            this.ultimoAbono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ultimoAbono.HeaderText = "Ultimo Abono Hecho";
            this.ultimoAbono.Name = "ultimoAbono";
            this.ultimoAbono.ReadOnly = true;
            this.ultimoAbono.Width = 119;
            // 
            // lbl_abono
            // 
            this.lbl_abono.AutoSize = true;
            this.lbl_abono.Location = new System.Drawing.Point(21, 33);
            this.lbl_abono.Name = "lbl_abono";
            this.lbl_abono.Size = new System.Drawing.Size(49, 13);
            this.lbl_abono.TabIndex = 1;
            this.lbl_abono.Text = "Cantidad";
            // 
            // txt_abono
            // 
            this.txt_abono.Location = new System.Drawing.Point(92, 30);
            this.txt_abono.Name = "txt_abono";
            this.txt_abono.Size = new System.Drawing.Size(78, 20);
            this.txt_abono.TabIndex = 1;
            this.txt_abono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_abono_KeyPress);
            // 
            // cb_empresa
            // 
            this.cb_empresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cb_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_empresa.FormattingEnabled = true;
            this.cb_empresa.Location = new System.Drawing.Point(238, 29);
            this.cb_empresa.Name = "cb_empresa";
            this.cb_empresa.Size = new System.Drawing.Size(147, 21);
            this.cb_empresa.TabIndex = 2;
            this.cb_empresa.SelectedIndexChanged += new System.EventHandler(this.cb_empresa_SelectedIndexChanged);
            this.cb_empresa.SelectionChangeCommitted += new System.EventHandler(this.cb_empresa_SelectionChangeCommitted);
            this.cb_empresa.SelectedValueChanged += new System.EventHandler(this.cb_empresa_SelectedValueChanged);
            // 
            // cb_proveedor
            // 
            this.cb_proveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cb_proveedor.FormattingEnabled = true;
            this.cb_proveedor.Location = new System.Drawing.Point(418, 30);
            this.cb_proveedor.Name = "cb_proveedor";
            this.cb_proveedor.Size = new System.Drawing.Size(143, 21);
            this.cb_proveedor.TabIndex = 3;
            this.cb_proveedor.Text = "Proveedor";
            this.cb_proveedor.SelectionChangeCommitted += new System.EventHandler(this.cb_proveedor_SelectionChangeCommitted);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.Location = new System.Drawing.Point(601, 401);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 5;
            this.btn_modificar.Text = "Guardar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(598, 33);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(37, 13);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "Fecha";
            // 
            // Abonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 446);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.cb_proveedor);
            this.Controls.Add(this.cb_empresa);
            this.Controls.Add(this.txt_abono);
            this.Controls.Add(this.lbl_abono);
            this.Controls.Add(this.dgv_abono);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Abonos";
            this.Text = "Abonos";
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_abono;
        private System.Windows.Forms.Label lbl_abono;
        private System.Windows.Forms.TextBox txt_abono;
        private System.Windows.Forms.ComboBox cb_empresa;
        private System.Windows.Forms.ComboBox cb_proveedor;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldotbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ultimoAbono;
    }
}