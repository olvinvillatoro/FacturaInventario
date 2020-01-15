namespace Facturacion
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Facturacion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Titulo = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_facturaPrin = new System.Windows.Forms.Button();
            this.btn_abonos = new System.Windows.Forms.Button();
            this.chrt_masVendido = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrt_ganancia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mtxt_telefonoCliente = new System.Windows.Forms.TextBox();
            this.mtxt_identidadCliente = new System.Windows.Forms.TextBox();
            this.btn_buscarCliente = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Comentarios = new System.Windows.Forms.TextBox();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.lbl_tituloCliente = new System.Windows.Forms.Label();
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Identidad = new System.Windows.Forms.Label();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cb_estado = new System.Windows.Forms.ComboBox();
            this.lbl_modificar = new System.Windows.Forms.Label();
            this.cb_proveedorInventario = new System.Windows.Forms.ComboBox();
            this.btn_BuscarInventario = new System.Windows.Forms.Button();
            this.lbl_asegurese = new System.Windows.Forms.Label();
            this.cb_CategoriaInventario = new System.Windows.Forms.ComboBox();
            this.txt_precioDescuento = new System.Windows.Forms.TextBox();
            this.txt_precioDeVenta = new System.Windows.Forms.TextBox();
            this.txt_precioCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_AgregarProductoInventario = new System.Windows.Forms.Button();
            this.btn_EliminarProducto = new System.Windows.Forms.Button();
            this.dgv_agregar = new System.Windows.Forms.DataGridView();
            this.txt_ubicacionProducto = new System.Windows.Forms.TextBox();
            this.txt_descripcionProducto = new System.Windows.Forms.TextBox();
            this.txt_cantidadProducto = new System.Windows.Forms.TextBox();
            this.txt_nombreProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbl_gananciasReportes = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbFecha = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.btnGenerar1 = new System.Windows.Forms.Button();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dgv_reporte = new System.Windows.Forms.DataGridView();
            this.notifyProveedores = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerProveedores = new System.Windows.Forms.Timer(this.components);
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_final = new System.Windows.Forms.DateTimePicker();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.lbl_final = new System.Windows.Forms.Label();
            this.btn_generar1 = new System.Windows.Forms.Button();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.btn_generar = new System.Windows.Forms.Button();
            this.cb_fecha = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.vistas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.abonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_estadoCliente = new System.Windows.Forms.ComboBox();
            this.Facturacion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_masVendido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_ganancia)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agregar)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Facturacion
            // 
            this.Facturacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Facturacion.Controls.Add(this.tabPage1);
            this.Facturacion.Controls.Add(this.tabPage2);
            this.Facturacion.Controls.Add(this.tabPage3);
            this.Facturacion.Controls.Add(this.tabPage4);
            this.Facturacion.Location = new System.Drawing.Point(2, 1);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.SelectedIndex = 0;
            this.Facturacion.Size = new System.Drawing.Size(1005, 716);
            this.Facturacion.TabIndex = 0;
            this.Facturacion.Tag = "";
            this.Facturacion.Click += new System.EventHandler(this.Facturacion_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.Titulo);
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 690);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Titulo.Location = new System.Drawing.Point(293, 3);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(0, 13);
            this.Titulo.TabIndex = 19;
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.btn_cancelar);
            this.splitContainer2.Panel1.Controls.Add(this.btn_facturaPrin);
            this.splitContainer2.Panel1.Controls.Add(this.btn_abonos);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.chrt_masVendido);
            this.splitContainer2.Panel2.Controls.Add(this.chrt_ganancia);
            this.splitContainer2.Size = new System.Drawing.Size(991, 684);
            this.splitContainer2.SplitterDistance = 330;
            this.splitContainer2.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(96, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 57);
            this.button1.TabIndex = 39;
            this.button1.Text = "Proveedores / Empresa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(96, 592);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(132, 57);
            this.btn_cancelar.TabIndex = 35;
            this.btn_cancelar.Text = "Salir";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // btn_facturaPrin
            // 
            this.btn_facturaPrin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_facturaPrin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturaPrin.Location = new System.Drawing.Point(96, 106);
            this.btn_facturaPrin.Name = "btn_facturaPrin";
            this.btn_facturaPrin.Size = new System.Drawing.Size(132, 57);
            this.btn_facturaPrin.TabIndex = 38;
            this.btn_facturaPrin.Text = "Ventas";
            this.btn_facturaPrin.UseVisualStyleBackColor = true;
            this.btn_facturaPrin.Click += new System.EventHandler(this.btn_facturaPrin_Click);
            // 
            // btn_abonos
            // 
            this.btn_abonos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_abonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abonos.Location = new System.Drawing.Point(96, 180);
            this.btn_abonos.Name = "btn_abonos";
            this.btn_abonos.Size = new System.Drawing.Size(132, 57);
            this.btn_abonos.TabIndex = 37;
            this.btn_abonos.Text = "Abonos";
            this.btn_abonos.UseVisualStyleBackColor = true;
            this.btn_abonos.Click += new System.EventHandler(this.btn_abonos_Click);
            // 
            // chrt_masVendido
            // 
            this.chrt_masVendido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea19.Name = "ChartArea1";
            this.chrt_masVendido.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.chrt_masVendido.Legends.Add(legend19);
            this.chrt_masVendido.Location = new System.Drawing.Point(3, 347);
            this.chrt_masVendido.Name = "chrt_masVendido";
            this.chrt_masVendido.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Dia Con Mas Ventas";
            this.chrt_masVendido.Series.Add(series10);
            this.chrt_masVendido.Size = new System.Drawing.Size(650, 334);
            this.chrt_masVendido.TabIndex = 39;
            this.chrt_masVendido.Text = "chart1";
            // 
            // chrt_ganancia
            // 
            this.chrt_ganancia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea20.Name = "ChartArea1";
            this.chrt_ganancia.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chrt_ganancia.Legends.Add(legend20);
            this.chrt_ganancia.Location = new System.Drawing.Point(2, 3);
            this.chrt_ganancia.Name = "chrt_ganancia";
            this.chrt_ganancia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chrt_ganancia.Size = new System.Drawing.Size(651, 338);
            this.chrt_ganancia.TabIndex = 38;
            this.chrt_ganancia.Text = "Ganancias";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.cb_estadoCliente);
            this.tabPage2.Controls.Add(this.mtxt_telefonoCliente);
            this.tabPage2.Controls.Add(this.mtxt_identidadCliente);
            this.tabPage2.Controls.Add(this.btn_buscarCliente);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txt_Comentarios);
            this.tabPage2.Controls.Add(this.btn_AgregarCliente);
            this.tabPage2.Controls.Add(this.lbl_tituloCliente);
            this.tabPage2.Controls.Add(this.dgv_Cliente);
            this.tabPage2.Controls.Add(this.txt_Direccion);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Identidad);
            this.tabPage2.Controls.Add(this.txt_NombreCliente);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 690);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // mtxt_telefonoCliente
            // 
            this.mtxt_telefonoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxt_telefonoCliente.Location = new System.Drawing.Point(736, 105);
            this.mtxt_telefonoCliente.MaxLength = 8;
            this.mtxt_telefonoCliente.Name = "mtxt_telefonoCliente";
            this.mtxt_telefonoCliente.Size = new System.Drawing.Size(100, 20);
            this.mtxt_telefonoCliente.TabIndex = 3;
            // 
            // mtxt_identidadCliente
            // 
            this.mtxt_identidadCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mtxt_identidadCliente.Location = new System.Drawing.Point(471, 106);
            this.mtxt_identidadCliente.MaxLength = 13;
            this.mtxt_identidadCliente.Name = "mtxt_identidadCliente";
            this.mtxt_identidadCliente.Size = new System.Drawing.Size(116, 20);
            this.mtxt_identidadCliente.TabIndex = 2;
            this.mtxt_identidadCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxt_identidadCliente_KeyPress);
            // 
            // btn_buscarCliente
            // 
            this.btn_buscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_buscarCliente.Location = new System.Drawing.Point(38, 637);
            this.btn_buscarCliente.Name = "btn_buscarCliente";
            this.btn_buscarCliente.Size = new System.Drawing.Size(131, 35);
            this.btn_buscarCliente.TabIndex = 9;
            this.btn_buscarCliente.Text = "Modificar Cliente";
            this.btn_buscarCliente.UseVisualStyleBackColor = true;
            this.btn_buscarCliente.Click += new System.EventHandler(this.btn_buscarCliente_Click);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(416, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Comentarios";
            // 
            // txt_Comentarios
            // 
            this.txt_Comentarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Comentarios.Location = new System.Drawing.Point(504, 148);
            this.txt_Comentarios.MaxLength = 100;
            this.txt_Comentarios.Multiline = true;
            this.txt_Comentarios.Name = "txt_Comentarios";
            this.txt_Comentarios.Size = new System.Drawing.Size(268, 38);
            this.txt_Comentarios.TabIndex = 5;
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AgregarCliente.Location = new System.Drawing.Point(859, 637);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(131, 35);
            this.btn_AgregarCliente.TabIndex = 8;
            this.btn_AgregarCliente.Text = "Guardar Cliente";
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // lbl_tituloCliente
            // 
            this.lbl_tituloCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_tituloCliente.AutoSize = true;
            this.lbl_tituloCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tituloCliente.Location = new System.Drawing.Point(347, 25);
            this.lbl_tituloCliente.Name = "lbl_tituloCliente";
            this.lbl_tituloCliente.Size = new System.Drawing.Size(230, 36);
            this.lbl_tituloCliente.TabIndex = 9;
            this.lbl_tituloCliente.Text = "Agregar  Cliente";
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.AllowUserToOrderColumns = true;
            this.dgv_Cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.Location = new System.Drawing.Point(38, 207);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.Size = new System.Drawing.Size(941, 349);
            this.dgv_Cliente.TabIndex = 7;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(86, 148);
            this.txt_Direccion.MaxLength = 100;
            this.txt_Direccion.Multiline = true;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(245, 38);
            this.txt_Direccion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direccion";
            // 
            // Identidad
            // 
            this.Identidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Identidad.AutoSize = true;
            this.Identidad.Location = new System.Drawing.Point(414, 109);
            this.Identidad.Name = "Identidad";
            this.Identidad.Size = new System.Drawing.Size(51, 13);
            this.Identidad.TabIndex = 2;
            this.Identidad.Text = "Identidad";
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(86, 101);
            this.txt_NombreCliente.MaxLength = 60;
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(245, 20);
            this.txt_NombreCliente.TabIndex = 1;
            this.txt_NombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NombreCliente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.cb_estado);
            this.tabPage3.Controls.Add(this.lbl_modificar);
            this.tabPage3.Controls.Add(this.cb_proveedorInventario);
            this.tabPage3.Controls.Add(this.btn_BuscarInventario);
            this.tabPage3.Controls.Add(this.lbl_asegurese);
            this.tabPage3.Controls.Add(this.cb_CategoriaInventario);
            this.tabPage3.Controls.Add(this.txt_precioDescuento);
            this.tabPage3.Controls.Add(this.txt_precioDeVenta);
            this.tabPage3.Controls.Add(this.txt_precioCompra);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.btn_AgregarProductoInventario);
            this.tabPage3.Controls.Add(this.btn_EliminarProducto);
            this.tabPage3.Controls.Add(this.dgv_agregar);
            this.tabPage3.Controls.Add(this.txt_ubicacionProducto);
            this.tabPage3.Controls.Add(this.txt_descripcionProducto);
            this.tabPage3.Controls.Add(this.txt_cantidadProducto);
            this.tabPage3.Controls.Add(this.txt_nombreProducto);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(997, 690);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // cb_estado
            // 
            this.cb_estado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.ItemHeight = 13;
            this.cb_estado.Location = new System.Drawing.Point(763, 259);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(95, 21);
            this.cb_estado.TabIndex = 10;
            this.cb_estado.Text = "Estado";
            this.cb_estado.Visible = false;
            // 
            // lbl_modificar
            // 
            this.lbl_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_modificar.AutoSize = true;
            this.lbl_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modificar.Location = new System.Drawing.Point(256, 49);
            this.lbl_modificar.Name = "lbl_modificar";
            this.lbl_modificar.Size = new System.Drawing.Size(425, 26);
            this.lbl_modificar.TabIndex = 17;
            this.lbl_modificar.Text = "ESTA MODIFICANDO ESTE PRODUCTO";
            this.lbl_modificar.Visible = false;
            // 
            // cb_proveedorInventario
            // 
            this.cb_proveedorInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_proveedorInventario.FormattingEnabled = true;
            this.cb_proveedorInventario.Location = new System.Drawing.Point(721, 140);
            this.cb_proveedorInventario.Name = "cb_proveedorInventario";
            this.cb_proveedorInventario.Size = new System.Drawing.Size(121, 21);
            this.cb_proveedorInventario.TabIndex = 4;
            this.cb_proveedorInventario.Text = "Proveedores";
            // 
            // btn_BuscarInventario
            // 
            this.btn_BuscarInventario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_BuscarInventario.Location = new System.Drawing.Point(391, 63);
            this.btn_BuscarInventario.Name = "btn_BuscarInventario";
            this.btn_BuscarInventario.Size = new System.Drawing.Size(190, 44);
            this.btn_BuscarInventario.TabIndex = 15;
            this.btn_BuscarInventario.Text = "Modificar Producto";
            this.btn_BuscarInventario.UseVisualStyleBackColor = true;
            this.btn_BuscarInventario.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_asegurese
            // 
            this.lbl_asegurese.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_asegurese.AutoSize = true;
            this.lbl_asegurese.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_asegurese.Location = new System.Drawing.Point(172, 34);
            this.lbl_asegurese.Name = "lbl_asegurese";
            this.lbl_asegurese.Size = new System.Drawing.Size(625, 26);
            this.lbl_asegurese.TabIndex = 14;
            this.lbl_asegurese.Text = "Asegurese que el producto a ingresar no exista en el inventario ";
            // 
            // cb_CategoriaInventario
            // 
            this.cb_CategoriaInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_CategoriaInventario.FormattingEnabled = true;
            this.cb_CategoriaInventario.Location = new System.Drawing.Point(557, 140);
            this.cb_CategoriaInventario.Name = "cb_CategoriaInventario";
            this.cb_CategoriaInventario.Size = new System.Drawing.Size(151, 21);
            this.cb_CategoriaInventario.TabIndex = 3;
            this.cb_CategoriaInventario.Text = "Categoria";
            // 
            // txt_precioDescuento
            // 
            this.txt_precioDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_precioDescuento.Location = new System.Drawing.Point(650, 259);
            this.txt_precioDescuento.Name = "txt_precioDescuento";
            this.txt_precioDescuento.Size = new System.Drawing.Size(94, 20);
            this.txt_precioDescuento.TabIndex = 9;
            this.txt_precioDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioCompra_KeyPress);
            // 
            // txt_precioDeVenta
            // 
            this.txt_precioDeVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_precioDeVenta.Location = new System.Drawing.Point(373, 260);
            this.txt_precioDeVenta.Name = "txt_precioDeVenta";
            this.txt_precioDeVenta.Size = new System.Drawing.Size(125, 20);
            this.txt_precioDeVenta.TabIndex = 8;
            this.txt_precioDeVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioCompra_KeyPress);
            // 
            // txt_precioCompra
            // 
            this.txt_precioCompra.Location = new System.Drawing.Point(129, 260);
            this.txt_precioCompra.Name = "txt_precioCompra";
            this.txt_precioCompra.Size = new System.Drawing.Size(125, 20);
            this.txt_precioCompra.TabIndex = 7;
            this.txt_precioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioCompra_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Precio Con Descuento  L.";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Precio de Venta   L.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Precio de Compra   L.";
            // 
            // btn_AgregarProductoInventario
            // 
            this.btn_AgregarProductoInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AgregarProductoInventario.Location = new System.Drawing.Point(783, 582);
            this.btn_AgregarProductoInventario.Name = "btn_AgregarProductoInventario";
            this.btn_AgregarProductoInventario.Size = new System.Drawing.Size(146, 32);
            this.btn_AgregarProductoInventario.TabIndex = 16;
            this.btn_AgregarProductoInventario.Text = "Guardar";
            this.btn_AgregarProductoInventario.UseVisualStyleBackColor = true;
            this.btn_AgregarProductoInventario.Click += new System.EventHandler(this.btn_AgregarProductoInventario_Click);
            // 
            // btn_EliminarProducto
            // 
            this.btn_EliminarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_EliminarProducto.Location = new System.Drawing.Point(65, 582);
            this.btn_EliminarProducto.Name = "btn_EliminarProducto";
            this.btn_EliminarProducto.Size = new System.Drawing.Size(127, 32);
            this.btn_EliminarProducto.TabIndex = 18;
            this.btn_EliminarProducto.Text = "Actualizar ventana";
            this.btn_EliminarProducto.UseVisualStyleBackColor = true;
            this.btn_EliminarProducto.Click += new System.EventHandler(this.btn_EliminarProducto_Click);
            // 
            // dgv_agregar
            // 
            this.dgv_agregar.AllowUserToOrderColumns = true;
            this.dgv_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_agregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agregar.Location = new System.Drawing.Point(29, 299);
            this.dgv_agregar.Name = "dgv_agregar";
            this.dgv_agregar.Size = new System.Drawing.Size(934, 246);
            this.dgv_agregar.TabIndex = 11;
            // 
            // txt_ubicacionProducto
            // 
            this.txt_ubicacionProducto.Location = new System.Drawing.Point(77, 181);
            this.txt_ubicacionProducto.MaxLength = 100;
            this.txt_ubicacionProducto.Multiline = true;
            this.txt_ubicacionProducto.Name = "txt_ubicacionProducto";
            this.txt_ubicacionProducto.Size = new System.Drawing.Size(297, 50);
            this.txt_ubicacionProducto.TabIndex = 5;
            // 
            // txt_descripcionProducto
            // 
            this.txt_descripcionProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcionProducto.Location = new System.Drawing.Point(526, 178);
            this.txt_descripcionProducto.MaxLength = 100;
            this.txt_descripcionProducto.Multiline = true;
            this.txt_descripcionProducto.Name = "txt_descripcionProducto";
            this.txt_descripcionProducto.Size = new System.Drawing.Size(316, 53);
            this.txt_descripcionProducto.TabIndex = 6;
            // 
            // txt_cantidadProducto
            // 
            this.txt_cantidadProducto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cantidadProducto.Location = new System.Drawing.Point(470, 140);
            this.txt_cantidadProducto.Name = "txt_cantidadProducto";
            this.txt_cantidadProducto.Size = new System.Drawing.Size(58, 20);
            this.txt_cantidadProducto.TabIndex = 2;
            this.txt_cantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidadProducto_KeyPress);
            // 
            // txt_nombreProducto
            // 
            this.txt_nombreProducto.Location = new System.Drawing.Point(77, 140);
            this.txt_nombreProducto.MaxLength = 60;
            this.txt_nombreProducto.Name = "txt_nombreProducto";
            this.txt_nombreProducto.Size = new System.Drawing.Size(297, 20);
            this.txt_nombreProducto.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ubicacion ";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(457, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Descripcion";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Producto";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbl_gananciasReportes);
            this.tabPage4.Controls.Add(this.splitContainer1);
            this.tabPage4.Controls.Add(this.dgv_reporte);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(997, 690);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reportes de Factura";
            this.tabPage4.ToolTipText = "Reportes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbl_gananciasReportes
            // 
            this.lbl_gananciasReportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_gananciasReportes.AutoSize = true;
            this.lbl_gananciasReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gananciasReportes.Location = new System.Drawing.Point(7, 633);
            this.lbl_gananciasReportes.Name = "lbl_gananciasReportes";
            this.lbl_gananciasReportes.Size = new System.Drawing.Size(0, 29);
            this.lbl_gananciasReportes.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cbFecha);
            this.splitContainer1.Panel1.Controls.Add(this.btnGenerar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtpFinal);
            this.splitContainer1.Panel2.Controls.Add(this.btnGenerar1);
            this.splitContainer1.Panel2.Controls.Add(this.dtpInicio);
            this.splitContainer1.Size = new System.Drawing.Size(1003, 100);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.TabIndex = 1;
            // 
            // cbFecha
            // 
            this.cbFecha.FormattingEnabled = true;
            this.cbFecha.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Mensual"});
            this.cbFecha.Location = new System.Drawing.Point(94, 34);
            this.cbFecha.Name = "cbFecha";
            this.cbFecha.Size = new System.Drawing.Size(121, 21);
            this.cbFecha.TabIndex = 1;
            this.cbFecha.SelectedIndexChanged += new System.EventHandler(this.Cbfecha_SelectedIndexChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Location = new System.Drawing.Point(405, 62);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dtpFinal
            // 
            this.dtpFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFinal.Location = new System.Drawing.Point(279, 19);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFinal.TabIndex = 0;
            // 
            // btnGenerar1
            // 
            this.btnGenerar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar1.Location = new System.Drawing.Point(404, 62);
            this.btnGenerar1.Name = "btnGenerar1";
            this.btnGenerar1.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar1.TabIndex = 0;
            this.btnGenerar1.Text = "Generar";
            this.btnGenerar1.UseVisualStyleBackColor = true;
            this.btnGenerar1.Click += new System.EventHandler(this.btnGenerar1_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpInicio.Location = new System.Drawing.Point(21, 19);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 0;
            // 
            // dgv_reporte
            // 
            this.dgv_reporte.AllowUserToAddRows = false;
            this.dgv_reporte.AllowUserToDeleteRows = false;
            this.dgv_reporte.AllowUserToOrderColumns = true;
            this.dgv_reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reporte.Location = new System.Drawing.Point(3, 109);
            this.dgv_reporte.Name = "dgv_reporte";
            this.dgv_reporte.ReadOnly = true;
            this.dgv_reporte.Size = new System.Drawing.Size(1000, 501);
            this.dgv_reporte.TabIndex = 0;
            this.dgv_reporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reporte_CellContentClick);
            this.dgv_reporte.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reporte_CellContentDoubleClick);
            this.dgv_reporte.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reporte_CellDoubleClick);
            // 
            // notifyProveedores
            // 
            this.notifyProveedores.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyProveedores.Icon")));
            this.notifyProveedores.Text = "Ferreteria Lara";
            this.notifyProveedores.Visible = true;
            this.notifyProveedores.BalloonTipClicked += new System.EventHandler(this.notifyProveedores_BalloonTipClicked);
            this.notifyProveedores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyProveedores_MouseClick);
            // 
            // timerProveedores
            // 
            this.timerProveedores.Enabled = true;
            this.timerProveedores.Interval = 5000;
            this.timerProveedores.Tick += new System.EventHandler(this.timerProveedores_Tick);
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CustomFormat = "";
            this.dtp_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_inicio.Location = new System.Drawing.Point(66, 9);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(96, 20);
            this.dtp_inicio.TabIndex = 0;
            // 
            // dtp_final
            // 
            this.dtp_final.CustomFormat = "";
            this.dtp_final.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_final.Location = new System.Drawing.Point(327, 9);
            this.dtp_final.MaxDate = new System.DateTime(2017, 12, 10, 0, 0, 0, 0);
            this.dtp_final.Name = "dtp_final";
            this.dtp_final.Size = new System.Drawing.Size(98, 20);
            this.dtp_final.TabIndex = 1;
            this.dtp_final.Value = new System.DateTime(2017, 12, 10, 0, 0, 0, 0);
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Location = new System.Drawing.Point(13, 14);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(38, 13);
            this.lbl_inicio.TabIndex = 2;
            // 
            // lbl_final
            // 
            this.lbl_final.AutoSize = true;
            this.lbl_final.Location = new System.Drawing.Point(254, 15);
            this.lbl_final.Name = "lbl_final";
            this.lbl_final.Size = new System.Drawing.Size(35, 13);
            this.lbl_final.TabIndex = 3;
            // 
            // btn_generar1
            // 
            this.btn_generar1.Location = new System.Drawing.Point(412, 72);
            this.btn_generar1.Name = "btn_generar1";
            this.btn_generar1.Size = new System.Drawing.Size(75, 23);
            this.btn_generar1.TabIndex = 4;
            this.btn_generar1.Text = "Generar";
            this.btn_generar1.UseVisualStyleBackColor = true;
            this.btn_generar1.Click += new System.EventHandler(this.btn_generar1_Click);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(22, 15);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_fecha.TabIndex = 0;
            // 
            // btn_generar
            // 
            this.btn_generar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_generar.Location = new System.Drawing.Point(409, 72);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 1;
            this.btn_generar.Text = "Generar";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // cb_fecha
            // 
            this.cb_fecha.FormattingEnabled = true;
            this.cb_fecha.Items.AddRange(new object[] {
            "Diario",
            "Semanal",
            "Mensual"});
            this.cb_fecha.Location = new System.Drawing.Point(70, 15);
            this.cb_fecha.Name = "cb_fecha";
            this.cb_fecha.Size = new System.Drawing.Size(121, 21);
            this.cb_fecha.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vistas,
            this.toolStripSeparator1,
            this.ventas,
            this.toolStripSeparator2,
            this.abonosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 82);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            this.contextMenuStrip1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseClick);
            // 
            // vistas
            // 
            this.vistas.Name = "vistas";
            this.vistas.Size = new System.Drawing.Size(115, 22);
            this.vistas.Text = "Visitas";
            this.vistas.Click += new System.EventHandler(this.vistas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // ventas
            // 
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(115, 22);
            this.ventas.Text = "Ventas";
            this.ventas.Click += new System.EventHandler(this.proveedores_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(112, 6);
            // 
            // abonosToolStripMenuItem
            // 
            this.abonosToolStripMenuItem.Name = "abonosToolStripMenuItem";
            this.abonosToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.abonosToolStripMenuItem.Text = "Abonos";
            this.abonosToolStripMenuItem.Click += new System.EventHandler(this.abonosToolStripMenuItem_Click);
            // 
            // cb_estadoCliente
            // 
            this.cb_estadoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_estadoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estadoCliente.FormattingEnabled = true;
            this.cb_estadoCliente.Items.AddRange(new object[] {
            "Activo",
            "Desactivado"});
            this.cb_estadoCliente.Location = new System.Drawing.Point(831, 154);
            this.cb_estadoCliente.Name = "cb_estadoCliente";
            this.cb_estadoCliente.Size = new System.Drawing.Size(121, 21);
            this.cb_estadoCliente.TabIndex = 6;
            this.cb_estadoCliente.Visible = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.Facturacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FERRETERIA LARA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Facturacion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrt_masVendido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrt_ganancia)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agregar)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reporte)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Facturacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.TextBox txt_ubicacionProducto;
        private System.Windows.Forms.TextBox txt_descripcionProducto;
        private System.Windows.Forms.TextBox txt_cantidadProducto;
        private System.Windows.Forms.TextBox txt_nombreProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_AgregarProductoInventario;
        private System.Windows.Forms.Button btn_EliminarProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_precioCompra;
        private System.Windows.Forms.ComboBox cb_CategoriaInventario;
        private System.Windows.Forms.Label lbl_asegurese;
        private System.Windows.Forms.Button btn_BuscarInventario;
        private System.Windows.Forms.TextBox txt_precioDeVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_proveedorInventario;
        private System.Windows.Forms.Label lbl_modificar;
        public System.Windows.Forms.DataGridView dgv_agregar;
        private System.Windows.Forms.ComboBox cb_estado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Comentarios;
        private System.Windows.Forms.Button btn_buscarCliente;
        public System.Windows.Forms.Label lbl_tituloCliente;
        public System.Windows.Forms.TextBox mtxt_identidadCliente;
        public System.Windows.Forms.Label Identidad;
        private System.Windows.Forms.TextBox mtxt_telefonoCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_masVendido;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrt_ganancia;
        private System.Windows.Forms.Button btn_facturaPrin;
        private System.Windows.Forms.Button btn_abonos;
        private System.Windows.Forms.NotifyIcon notifyProveedores;
        private System.Windows.Forms.Timer timerProveedores;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv_reporte;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_final;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Label lbl_final;
        private System.Windows.Forms.Button btn_generar1;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.ComboBox cb_fecha;
        private System.Windows.Forms.ComboBox cbFecha;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button btnGenerar1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vistas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ventas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem abonosToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_precioDescuento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_gananciasReportes;
        public System.Windows.Forms.ComboBox cb_estadoCliente;
    }
}

