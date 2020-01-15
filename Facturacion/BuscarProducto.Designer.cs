namespace Facturacion
{
    partial class BuscarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProducto));
            this.dgv_buscar = new System.Windows.Forms.DataGridView();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_codigoBuscar = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_modificarProducto = new System.Windows.Forms.Button();
            this.checkBoxDescuento = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_buscar
            // 
            this.dgv_buscar.AllowUserToAddRows = false;
            this.dgv_buscar.AllowUserToDeleteRows = false;
            this.dgv_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_buscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_buscar.Location = new System.Drawing.Point(12, 132);
            this.dgv_buscar.Name = "dgv_buscar";
            this.dgv_buscar.ReadOnly = true;
            this.dgv_buscar.Size = new System.Drawing.Size(860, 385);
            this.dgv_buscar.TabIndex = 13;
            this.dgv_buscar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_buscar_CellDoubleClick);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.Location = new System.Drawing.Point(665, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(197, 64);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar Producto";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_codigoBuscar
            // 
            this.txt_codigoBuscar.Location = new System.Drawing.Point(108, 35);
            this.txt_codigoBuscar.MaxLength = 13;
            this.txt_codigoBuscar.Name = "txt_codigoBuscar";
            this.txt_codigoBuscar.Size = new System.Drawing.Size(100, 20);
            this.txt_codigoBuscar.TabIndex = 1;
            this.txt_codigoBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigoBuscar_KeyPress);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(50, 38);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(40, 13);
            this.lbl_codigo.TabIndex = 8;
            this.lbl_codigo.Text = "Codigo";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(227, 38);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(107, 13);
            this.lbl_nombre.TabIndex = 14;
            this.lbl_nombre.Text = "Nombre del Producto";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(340, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btn_modificarProducto
            // 
            this.btn_modificarProducto.Location = new System.Drawing.Point(797, 532);
            this.btn_modificarProducto.Name = "btn_modificarProducto";
            this.btn_modificarProducto.Size = new System.Drawing.Size(75, 23);
            this.btn_modificarProducto.TabIndex = 15;
            this.btn_modificarProducto.Text = "Modificar";
            this.btn_modificarProducto.UseVisualStyleBackColor = true;
            this.btn_modificarProducto.Visible = false;
            this.btn_modificarProducto.Click += new System.EventHandler(this.btn_modificarProducto_Click);
            // 
            // checkBoxDescuento
            // 
            this.checkBoxDescuento.AutoSize = true;
            this.checkBoxDescuento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxDescuento.Location = new System.Drawing.Point(108, 61);
            this.checkBoxDescuento.Name = "checkBoxDescuento";
            this.checkBoxDescuento.Size = new System.Drawing.Size(386, 18);
            this.checkBoxDescuento.TabIndex = 3;
            this.checkBoxDescuento.Text = "Click Aqui Para Agregar El Producto a la Factura Con Precio de Descuento";
            this.checkBoxDescuento.UseVisualStyleBackColor = true;
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 567);
            this.Controls.Add(this.checkBoxDescuento);
            this.Controls.Add(this.btn_modificarProducto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.dgv_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_codigoBuscar);
            this.Controls.Add(this.lbl_codigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "BuscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_codigoBuscar;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button btn_modificarProducto;
        public System.Windows.Forms.CheckBox checkBoxDescuento;
    }
}