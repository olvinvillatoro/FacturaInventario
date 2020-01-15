namespace Facturacion
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Visita = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_visita = new System.Windows.Forms.ComboBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.dgv_visitas = new System.Windows.Forms.DataGridView();
            this.tb_empresa = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_guardarEmpresa = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_Direccionn = new System.Windows.Forms.TextBox();
            this.txt_saldoPendienteE = new System.Windows.Forms.TextBox();
            this.telefonoEmpresa = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_rtnEmpresa = new System.Windows.Forms.Label();
            this.txt_nombreEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rtn = new System.Windows.Forms.TextBox();
            this.dgv_empresa = new System.Windows.Forms.DataGridView();
            this.tp_proveedor = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.dgv_proveedores = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.dtpVisita = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.btnGurdar = new System.Windows.Forms.Button();
            this.tp_modificar = new System.Windows.Forms.TabPage();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_modificar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nombreModificar = new System.Windows.Forms.TextBox();
            this.txt_idModificar = new System.Windows.Forms.TextBox();
            this.btn_BuscarModificar = new System.Windows.Forms.Button();
            this.dgv_modificar = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cb_estadoEmpresa = new System.Windows.Forms.ComboBox();
            this.cb_estadoProveedores = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tp_Visita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visitas)).BeginInit();
            this.tb_empresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresa)).BeginInit();
            this.tp_proveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).BeginInit();
            this.tp_modificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modificar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tp_Visita);
            this.tabControl1.Controls.Add(this.tb_empresa);
            this.tabControl1.Controls.Add(this.tp_proveedor);
            this.tabControl1.Controls.Add(this.tp_modificar);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 597);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_Visita
            // 
            this.tp_Visita.Controls.Add(this.label5);
            this.tp_Visita.Controls.Add(this.button1);
            this.tp_Visita.Controls.Add(this.cb_visita);
            this.tp_Visita.Controls.Add(this.lbl_Titulo);
            this.tp_Visita.Controls.Add(this.dgv_visitas);
            this.tp_Visita.Location = new System.Drawing.Point(4, 22);
            this.tp_Visita.Name = "tp_Visita";
            this.tp_Visita.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Visita.Size = new System.Drawing.Size(887, 571);
            this.tp_Visita.TabIndex = 0;
            this.tp_Visita.Text = "Visitas";
            this.tp_Visita.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Visitas";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(495, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_visita
            // 
            this.cb_visita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_visita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_visita.FormattingEnabled = true;
            this.cb_visita.Items.AddRange(new object[] {
            "Proximas Dos Semanas",
            "Proximo Mes"});
            this.cb_visita.Location = new System.Drawing.Point(284, 115);
            this.cb_visita.Name = "cb_visita";
            this.cb_visita.Size = new System.Drawing.Size(152, 21);
            this.cb_visita.TabIndex = 2;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(203, 13);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(486, 39);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Visitas En La Proxima Semana";
            // 
            // dgv_visitas
            // 
            this.dgv_visitas.AllowUserToAddRows = false;
            this.dgv_visitas.AllowUserToDeleteRows = false;
            this.dgv_visitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_visitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_visitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_visitas.Location = new System.Drawing.Point(6, 216);
            this.dgv_visitas.Name = "dgv_visitas";
            this.dgv_visitas.ReadOnly = true;
            this.dgv_visitas.Size = new System.Drawing.Size(875, 349);
            this.dgv_visitas.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgv_visitas, "Doble Click Para Ver Saldo Y La Informacion De La Empresa ");
            this.dgv_visitas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_proveedores_CellDoubleClick);
            this.dgv_visitas.MouseEnter += new System.EventHandler(this.dgv_visitas_MouseEnter);
            this.dgv_visitas.MouseHover += new System.EventHandler(this.dgv_visitas_MouseHover);
            // 
            // tb_empresa
            // 
            this.tb_empresa.Controls.Add(this.cb_estadoEmpresa);
            this.tb_empresa.Controls.Add(this.label15);
            this.tb_empresa.Controls.Add(this.btn_guardarEmpresa);
            this.tb_empresa.Controls.Add(this.label11);
            this.tb_empresa.Controls.Add(this.lbl_Direccion);
            this.tb_empresa.Controls.Add(this.label9);
            this.tb_empresa.Controls.Add(this.txt_descripcion);
            this.tb_empresa.Controls.Add(this.txt_Direccionn);
            this.tb_empresa.Controls.Add(this.txt_saldoPendienteE);
            this.tb_empresa.Controls.Add(this.telefonoEmpresa);
            this.tb_empresa.Controls.Add(this.txt_telefono);
            this.tb_empresa.Controls.Add(this.lbl_rtnEmpresa);
            this.tb_empresa.Controls.Add(this.txt_nombreEmpresa);
            this.tb_empresa.Controls.Add(this.label6);
            this.tb_empresa.Controls.Add(this.txt_rtn);
            this.tb_empresa.Controls.Add(this.dgv_empresa);
            this.tb_empresa.Location = new System.Drawing.Point(4, 22);
            this.tb_empresa.Name = "tb_empresa";
            this.tb_empresa.Padding = new System.Windows.Forms.Padding(3);
            this.tb_empresa.Size = new System.Drawing.Size(887, 571);
            this.tb_empresa.TabIndex = 1;
            this.tb_empresa.Text = "Empresas";
            this.tb_empresa.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(347, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 39);
            this.label15.TabIndex = 26;
            this.label15.Text = "Empresas";
            // 
            // btn_guardarEmpresa
            // 
            this.btn_guardarEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_guardarEmpresa.Location = new System.Drawing.Point(803, 192);
            this.btn_guardarEmpresa.Name = "btn_guardarEmpresa";
            this.btn_guardarEmpresa.Size = new System.Drawing.Size(75, 23);
            this.btn_guardarEmpresa.TabIndex = 8;
            this.btn_guardarEmpresa.Text = "Guardar";
            this.btn_guardarEmpresa.UseVisualStyleBackColor = true;
            this.btn_guardarEmpresa.Click += new System.EventHandler(this.btn_guardarEmpresa_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Descripcion";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(71, 136);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(52, 13);
            this.lbl_Direccion.TabIndex = 3;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(619, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Saldo Pendiente";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcion.Location = new System.Drawing.Point(453, 133);
            this.txt_descripcion.MaxLength = 100;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(214, 57);
            this.txt_descripcion.TabIndex = 6;
            // 
            // txt_Direccionn
            // 
            this.txt_Direccionn.Location = new System.Drawing.Point(129, 133);
            this.txt_Direccionn.MaxLength = 100;
            this.txt_Direccionn.Multiline = true;
            this.txt_Direccionn.Name = "txt_Direccionn";
            this.txt_Direccionn.Size = new System.Drawing.Size(214, 57);
            this.txt_Direccionn.TabIndex = 5;
            // 
            // txt_saldoPendienteE
            // 
            this.txt_saldoPendienteE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_saldoPendienteE.Location = new System.Drawing.Point(710, 85);
            this.txt_saldoPendienteE.Name = "txt_saldoPendienteE";
            this.txt_saldoPendienteE.Size = new System.Drawing.Size(100, 20);
            this.txt_saldoPendienteE.TabIndex = 4;
            this.txt_saldoPendienteE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_saldoPendienteE_KeyPress);
            // 
            // telefonoEmpresa
            // 
            this.telefonoEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.telefonoEmpresa.AutoSize = true;
            this.telefonoEmpresa.Location = new System.Drawing.Point(423, 87);
            this.telefonoEmpresa.Name = "telefonoEmpresa";
            this.telefonoEmpresa.Size = new System.Drawing.Size(49, 13);
            this.telefonoEmpresa.TabIndex = 3;
            this.telefonoEmpresa.Text = "Telefono";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_telefono.Location = new System.Drawing.Point(487, 84);
            this.txt_telefono.MaxLength = 8;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_telefono.TabIndex = 3;
            this.txt_telefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_telefono_KeyDown);
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // lbl_rtnEmpresa
            // 
            this.lbl_rtnEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_rtnEmpresa.AutoSize = true;
            this.lbl_rtnEmpresa.Location = new System.Drawing.Point(38, 87);
            this.lbl_rtnEmpresa.Name = "lbl_rtnEmpresa";
            this.lbl_rtnEmpresa.Size = new System.Drawing.Size(30, 13);
            this.lbl_rtnEmpresa.TabIndex = 3;
            this.lbl_rtnEmpresa.Text = "RTN";
            // 
            // txt_nombreEmpresa
            // 
            this.txt_nombreEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nombreEmpresa.Location = new System.Drawing.Point(279, 84);
            this.txt_nombreEmpresa.MaxLength = 60;
            this.txt_nombreEmpresa.Name = "txt_nombreEmpresa";
            this.txt_nombreEmpresa.Size = new System.Drawing.Size(100, 20);
            this.txt_nombreEmpresa.TabIndex = 2;
            this.txt_nombreEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombreEmpresa_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Empresa";
            // 
            // txt_rtn
            // 
            this.txt_rtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_rtn.Location = new System.Drawing.Point(74, 84);
            this.txt_rtn.MaxLength = 14;
            this.txt_rtn.Name = "txt_rtn";
            this.txt_rtn.Size = new System.Drawing.Size(100, 20);
            this.txt_rtn.TabIndex = 1;
            this.txt_rtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rtn_KeyPress);
            // 
            // dgv_empresa
            // 
            this.dgv_empresa.AllowUserToAddRows = false;
            this.dgv_empresa.AllowUserToDeleteRows = false;
            this.dgv_empresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_empresa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_empresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empresa.Location = new System.Drawing.Point(6, 221);
            this.dgv_empresa.Name = "dgv_empresa";
            this.dgv_empresa.ReadOnly = true;
            this.dgv_empresa.Size = new System.Drawing.Size(875, 363);
            this.dgv_empresa.TabIndex = 9;
            // 
            // tp_proveedor
            // 
            this.tp_proveedor.Controls.Add(this.cb_estadoProveedores);
            this.tp_proveedor.Controls.Add(this.label14);
            this.tp_proveedor.Controls.Add(this.dgv_proveedores);
            this.tp_proveedor.Controls.Add(this.label4);
            this.tp_proveedor.Controls.Add(this.cbEmpresa);
            this.tp_proveedor.Controls.Add(this.dtpVisita);
            this.tp_proveedor.Controls.Add(this.label3);
            this.tp_proveedor.Controls.Add(this.label2);
            this.tp_proveedor.Controls.Add(this.label1);
            this.tp_proveedor.Controls.Add(this.txtCorreo);
            this.tp_proveedor.Controls.Add(this.txtTelefono);
            this.tp_proveedor.Controls.Add(this.txt_Nombre);
            this.tp_proveedor.Controls.Add(this.btnGurdar);
            this.tp_proveedor.Location = new System.Drawing.Point(4, 22);
            this.tp_proveedor.Name = "tp_proveedor";
            this.tp_proveedor.Padding = new System.Windows.Forms.Padding(3);
            this.tp_proveedor.Size = new System.Drawing.Size(887, 571);
            this.tp_proveedor.TabIndex = 2;
            this.tp_proveedor.Text = "Proveedores";
            this.tp_proveedor.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(454, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Empresa";
            // 
            // dgv_proveedores
            // 
            this.dgv_proveedores.AllowUserToAddRows = false;
            this.dgv_proveedores.AllowUserToDeleteRows = false;
            this.dgv_proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_proveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.telefono,
            this.correo,
            this.fechaVisita,
            this.empresa});
            this.dgv_proveedores.Location = new System.Drawing.Point(6, 236);
            this.dgv_proveedores.Name = "dgv_proveedores";
            this.dgv_proveedores.ReadOnly = true;
            this.dgv_proveedores.Size = new System.Drawing.Size(872, 316);
            this.dgv_proveedores.TabIndex = 25;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // fechaVisita
            // 
            this.fechaVisita.HeaderText = "Fecha De Visita";
            this.fechaVisita.Name = "fechaVisita";
            this.fechaVisita.ReadOnly = true;
            // 
            // empresa
            // 
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 39);
            this.label4.TabIndex = 25;
            this.label4.Text = "Proveedores";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.ItemHeight = 13;
            this.cbEmpresa.Location = new System.Drawing.Point(508, 94);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cbEmpresa.TabIndex = 20;
            // 
            // dtpVisita
            // 
            this.dtpVisita.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpVisita.Location = new System.Drawing.Point(663, 94);
            this.dtpVisita.Name = "dtpVisita";
            this.dtpVisita.Size = new System.Drawing.Size(200, 20);
            this.dtpVisita.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Correo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nombre";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(81, 144);
            this.txtCorreo.MaxLength = 60;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(127, 20);
            this.txtCorreo.TabIndex = 22;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefono.Location = new System.Drawing.Point(304, 94);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(127, 20);
            this.txtTelefono.TabIndex = 19;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(81, 94);
            this.txt_Nombre.MaxLength = 60;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(127, 20);
            this.txt_Nombre.TabIndex = 18;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // btnGurdar
            // 
            this.btnGurdar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGurdar.Location = new System.Drawing.Point(788, 187);
            this.btnGurdar.Name = "btnGurdar";
            this.btnGurdar.Size = new System.Drawing.Size(75, 23);
            this.btnGurdar.TabIndex = 24;
            this.btnGurdar.Text = "Guardar";
            this.btnGurdar.UseVisualStyleBackColor = true;
            this.btnGurdar.Click += new System.EventHandler(this.btnGurdar_Click);
            // 
            // tp_modificar
            // 
            this.tp_modificar.Controls.Add(this.lbl_id);
            this.tp_modificar.Controls.Add(this.label12);
            this.tp_modificar.Controls.Add(this.label10);
            this.tp_modificar.Controls.Add(this.cb_modificar);
            this.tp_modificar.Controls.Add(this.label8);
            this.tp_modificar.Controls.Add(this.txt_nombreModificar);
            this.tp_modificar.Controls.Add(this.txt_idModificar);
            this.tp_modificar.Controls.Add(this.btn_BuscarModificar);
            this.tp_modificar.Controls.Add(this.dgv_modificar);
            this.tp_modificar.Location = new System.Drawing.Point(4, 22);
            this.tp_modificar.Name = "tp_modificar";
            this.tp_modificar.Size = new System.Drawing.Size(887, 571);
            this.tp_modificar.TabIndex = 3;
            this.tp_modificar.Text = "Buscar";
            this.tp_modificar.UseVisualStyleBackColor = true;
            // 
            // lbl_id
            // 
            this.lbl_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(503, 107);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 13);
            this.lbl_id.TabIndex = 7;
            this.lbl_id.Text = "ID";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(241, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Nombre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(311, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "DobleClick En Que Desea Modificar";
            // 
            // cb_modificar
            // 
            this.cb_modificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_modificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modificar.FormattingEnabled = true;
            this.cb_modificar.Items.AddRange(new object[] {
            "Empresa",
            "Proveedor"});
            this.cb_modificar.Location = new System.Drawing.Point(54, 102);
            this.cb_modificar.Name = "cb_modificar";
            this.cb_modificar.Size = new System.Drawing.Size(153, 21);
            this.cb_modificar.TabIndex = 1;
            this.cb_modificar.SelectionChangeCommitted += new System.EventHandler(this.cb_modificar_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(444, 36);
            this.label8.TabIndex = 4;
            this.label8.Text = "Seleccione Que Desea Buscar";
            // 
            // txt_nombreModificar
            // 
            this.txt_nombreModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_nombreModificar.Location = new System.Drawing.Point(291, 104);
            this.txt_nombreModificar.MaxLength = 45;
            this.txt_nombreModificar.Name = "txt_nombreModificar";
            this.txt_nombreModificar.Size = new System.Drawing.Size(174, 20);
            this.txt_nombreModificar.TabIndex = 2;
            // 
            // txt_idModificar
            // 
            this.txt_idModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_idModificar.Location = new System.Drawing.Point(550, 103);
            this.txt_idModificar.MaxLength = 14;
            this.txt_idModificar.Name = "txt_idModificar";
            this.txt_idModificar.Size = new System.Drawing.Size(174, 20);
            this.txt_idModificar.TabIndex = 3;
            // 
            // btn_BuscarModificar
            // 
            this.btn_BuscarModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_BuscarModificar.Location = new System.Drawing.Point(763, 102);
            this.btn_BuscarModificar.Name = "btn_BuscarModificar";
            this.btn_BuscarModificar.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarModificar.TabIndex = 4;
            this.btn_BuscarModificar.Text = "Buscar";
            this.btn_BuscarModificar.UseVisualStyleBackColor = true;
            this.btn_BuscarModificar.Click += new System.EventHandler(this.btn_BuscarModificar_Click);
            // 
            // dgv_modificar
            // 
            this.dgv_modificar.AllowUserToAddRows = false;
            this.dgv_modificar.AllowUserToDeleteRows = false;
            this.dgv_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_modificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modificar.Location = new System.Drawing.Point(23, 176);
            this.dgv_modificar.Name = "dgv_modificar";
            this.dgv_modificar.ReadOnly = true;
            this.dgv_modificar.Size = new System.Drawing.Size(844, 355);
            this.dgv_modificar.TabIndex = 5;
            this.dgv_modificar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_modificar_CellDoubleClick);
            this.dgv_modificar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgv_modificar_MouseDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // cb_estadoEmpresa
            // 
            this.cb_estadoEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_estadoEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estadoEmpresa.FormattingEnabled = true;
            this.cb_estadoEmpresa.Items.AddRange(new object[] {
            "Activo",
            "Desactivado"});
            this.cb_estadoEmpresa.Location = new System.Drawing.Point(738, 136);
            this.cb_estadoEmpresa.Name = "cb_estadoEmpresa";
            this.cb_estadoEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cb_estadoEmpresa.TabIndex = 7;
            this.cb_estadoEmpresa.Visible = false;
            // 
            // cb_estadoProveedores
            // 
            this.cb_estadoProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_estadoProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estadoProveedores.FormattingEnabled = true;
            this.cb_estadoProveedores.Items.AddRange(new object[] {
            "Activo",
            "Desactivado"});
            this.cb_estadoProveedores.Location = new System.Drawing.Point(742, 147);
            this.cb_estadoProveedores.Name = "cb_estadoProveedores";
            this.cb_estadoProveedores.Size = new System.Drawing.Size(121, 21);
            this.cb_estadoProveedores.TabIndex = 23;
            this.cb_estadoProveedores.Visible = false;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 609);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_Visita.ResumeLayout(false);
            this.tp_Visita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_visitas)).EndInit();
            this.tb_empresa.ResumeLayout(false);
            this.tb_empresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empresa)).EndInit();
            this.tp_proveedor.ResumeLayout(false);
            this.tp_proveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedores)).EndInit();
            this.tp_modificar.ResumeLayout(false);
            this.tp_modificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modificar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tp_Visita;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DataGridView dgv_visitas;
        private System.Windows.Forms.DataGridView dgv_empresa;
        protected System.Windows.Forms.TabPage tb_empresa;
        private System.Windows.Forms.TabPage tp_proveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.DateTimePicker dtpVisita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Button btnGurdar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_visita;
        private System.Windows.Forms.TabPage tp_modificar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgv_proveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.Button btn_guardarEmpresa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_Direccionn;
        private System.Windows.Forms.TextBox txt_saldoPendienteE;
        private System.Windows.Forms.Label telefonoEmpresa;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_rtnEmpresa;
        private System.Windows.Forms.TextBox txt_nombreEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_rtn;
        private System.Windows.Forms.ComboBox cb_modificar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_nombreModificar;
        private System.Windows.Forms.TextBox txt_idModificar;
        private System.Windows.Forms.Button btn_BuscarModificar;
        private System.Windows.Forms.DataGridView dgv_modificar;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_estadoEmpresa;
        private System.Windows.Forms.ComboBox cb_estadoProveedores;
    }
}