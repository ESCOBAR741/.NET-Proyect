namespace SeguimientoGasto
{
    partial class Admin
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
            this.rbUsuarios = new System.Windows.Forms.RadioButton();
            this.rbDepto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDepto = new System.Windows.Forms.ComboBox();
            this.txtDepto = new System.Windows.Forms.TextBox();
            this.dgvDepto = new System.Windows.Forms.DataGridView();
            this.nombreDepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvGastos = new System.Windows.Forms.DataGridView();
            this.idGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbTipoGasto = new System.Windows.Forms.ComboBox();
            this.cbDetalle = new System.Windows.Forms.ComboBox();
            this.rbGastos = new System.Windows.Forms.RadioButton();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblFechaGasto = new System.Windows.Forms.Label();
            this.rbBuscar = new System.Windows.Forms.RadioButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbUsuarios
            // 
            this.rbUsuarios.AutoSize = true;
            this.rbUsuarios.Location = new System.Drawing.Point(103, 38);
            this.rbUsuarios.Name = "rbUsuarios";
            this.rbUsuarios.Size = new System.Drawing.Size(134, 20);
            this.rbUsuarios.TabIndex = 0;
            this.rbUsuarios.TabStop = true;
            this.rbUsuarios.Text = "Seccion Usuarios";
            this.rbUsuarios.UseVisualStyleBackColor = true;
            // 
            // rbDepto
            // 
            this.rbDepto.AutoSize = true;
            this.rbDepto.Location = new System.Drawing.Point(447, 38);
            this.rbDepto.Name = "rbDepto";
            this.rbDepto.Size = new System.Drawing.Size(117, 20);
            this.rbDepto.TabIndex = 1;
            this.rbDepto.TabStop = true;
            this.rbDepto.Text = "Seccion Depto";
            this.rbDepto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(113, 77);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(240, 22);
            this.txtNombres.TabIndex = 4;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(113, 108);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(240, 22);
            this.txtApellidos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Run;";
            // 
            // txtRun
            // 
            this.txtRun.Location = new System.Drawing.Point(113, 137);
            this.txtRun.Name = "txtRun";
            this.txtRun.Size = new System.Drawing.Size(173, 22);
            this.txtRun.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(113, 167);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(173, 22);
            this.txtUsuario.TabIndex = 10;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(113, 198);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(173, 22);
            this.txtContraseña.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Depto:";
            // 
            // cbDepto
            // 
            this.cbDepto.FormattingEnabled = true;
            this.cbDepto.Items.AddRange(new object[] {
            "finanzas",
            "informatica",
            "rrhh",
            "mantencion"});
            this.cbDepto.Location = new System.Drawing.Point(113, 264);
            this.cbDepto.Name = "cbDepto";
            this.cbDepto.Size = new System.Drawing.Size(240, 24);
            this.cbDepto.TabIndex = 13;
            // 
            // txtDepto
            // 
            this.txtDepto.Location = new System.Drawing.Point(388, 77);
            this.txtDepto.Name = "txtDepto";
            this.txtDepto.Size = new System.Drawing.Size(240, 22);
            this.txtDepto.TabIndex = 16;
            // 
            // dgvDepto
            // 
            this.dgvDepto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDepto});
            this.dgvDepto.Location = new System.Drawing.Point(388, 114);
            this.dgvDepto.Name = "dgvDepto";
            this.dgvDepto.RowHeadersWidth = 51;
            this.dgvDepto.RowTemplate.Height = 24;
            this.dgvDepto.Size = new System.Drawing.Size(240, 136);
            this.dgvDepto.TabIndex = 17;
            this.dgvDepto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepto_CellClick);
            this.dgvDepto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepto_CellContentClick);
            // 
            // nombreDepto
            // 
            this.nombreDepto.HeaderText = "Nombre";
            this.nombreDepto.MinimumWidth = 6;
            this.nombreDepto.Name = "nombreDepto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(683, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tipo gasto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(683, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Detalle:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(683, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Descripcion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(683, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Monto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(683, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Fecha Gasto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(683, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Usuario:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(781, 136);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(202, 22);
            this.txtDescripcion.TabIndex = 28;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(781, 167);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(202, 22);
            this.txtMonto.TabIndex = 29;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(225, 302);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 32;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(398, 302);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(553, 302);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(703, 302);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 35;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(242, 340);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(435, 22);
            this.txtBuscarNombre.TabIndex = 37;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscarNombre_TextChanged);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.runDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.idDeptoDataGridViewTextBoxColumn,
            this.departamentosDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.usuariosBindingSource2;
            this.dgvUsuarios.Location = new System.Drawing.Point(42, 424);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(959, 150);
            this.dgvUsuarios.TabIndex = 38;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "nombres";
            this.nombresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // runDataGridViewTextBoxColumn
            // 
            this.runDataGridViewTextBoxColumn.DataPropertyName = "run";
            this.runDataGridViewTextBoxColumn.HeaderText = "run";
            this.runDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.runDataGridViewTextBoxColumn.Name = "runDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "contraseña";
            this.contraseñaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            // 
            // idDeptoDataGridViewTextBoxColumn
            // 
            this.idDeptoDataGridViewTextBoxColumn.DataPropertyName = "idDepto";
            this.idDeptoDataGridViewTextBoxColumn.HeaderText = "idDepto";
            this.idDeptoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDeptoDataGridViewTextBoxColumn.Name = "idDeptoDataGridViewTextBoxColumn";
            // 
            // departamentosDataGridViewTextBoxColumn
            // 
            this.departamentosDataGridViewTextBoxColumn.DataPropertyName = "Departamentos";
            this.departamentosDataGridViewTextBoxColumn.HeaderText = "Departamentos";
            this.departamentosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departamentosDataGridViewTextBoxColumn.Name = "departamentosDataGridViewTextBoxColumn";
            // 
            // usuariosBindingSource2
            // 
            this.usuariosBindingSource2.DataSource = typeof(SeguimientoGasto.Usuarios);
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(SeguimientoGasto.Usuarios);
            // 
            // dgvGastos
            // 
            this.dgvGastos.AutoGenerateColumns = false;
            this.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGastoDataGridViewTextBoxColumn,
            this.tipoGastoDataGridViewTextBoxColumn,
            this.detalleDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.fechaGastoDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn1,
            this.usuariosDataGridViewTextBoxColumn});
            this.dgvGastos.DataSource = this.gastosBindingSource1;
            this.dgvGastos.Location = new System.Drawing.Point(36, 664);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.RowHeadersWidth = 51;
            this.dgvGastos.RowTemplate.Height = 24;
            this.dgvGastos.Size = new System.Drawing.Size(965, 150);
            this.dgvGastos.TabIndex = 39;
            this.dgvGastos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGastos_CellClick);
            this.dgvGastos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGastos_CellContentClick);
            // 
            // idGastoDataGridViewTextBoxColumn
            // 
            this.idGastoDataGridViewTextBoxColumn.DataPropertyName = "idGasto";
            this.idGastoDataGridViewTextBoxColumn.HeaderText = "idGasto";
            this.idGastoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGastoDataGridViewTextBoxColumn.Name = "idGastoDataGridViewTextBoxColumn";
            // 
            // tipoGastoDataGridViewTextBoxColumn
            // 
            this.tipoGastoDataGridViewTextBoxColumn.DataPropertyName = "tipoGasto";
            this.tipoGastoDataGridViewTextBoxColumn.HeaderText = "tipoGasto";
            this.tipoGastoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoGastoDataGridViewTextBoxColumn.Name = "tipoGastoDataGridViewTextBoxColumn";
            // 
            // detalleDataGridViewTextBoxColumn
            // 
            this.detalleDataGridViewTextBoxColumn.DataPropertyName = "detalle";
            this.detalleDataGridViewTextBoxColumn.HeaderText = "detalle";
            this.detalleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detalleDataGridViewTextBoxColumn.Name = "detalleDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            // 
            // fechaGastoDataGridViewTextBoxColumn
            // 
            this.fechaGastoDataGridViewTextBoxColumn.DataPropertyName = "fechaGasto";
            this.fechaGastoDataGridViewTextBoxColumn.HeaderText = "fechaGasto";
            this.fechaGastoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaGastoDataGridViewTextBoxColumn.Name = "fechaGastoDataGridViewTextBoxColumn";
            // 
            // idUsuarioDataGridViewTextBoxColumn1
            // 
            this.idUsuarioDataGridViewTextBoxColumn1.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn1.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn1.Name = "idUsuarioDataGridViewTextBoxColumn1";
            // 
            // usuariosDataGridViewTextBoxColumn
            // 
            this.usuariosDataGridViewTextBoxColumn.DataPropertyName = "Usuarios";
            this.usuariosDataGridViewTextBoxColumn.HeaderText = "Usuarios";
            this.usuariosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuariosDataGridViewTextBoxColumn.Name = "usuariosDataGridViewTextBoxColumn";
            // 
            // gastosBindingSource1
            // 
            this.gastosBindingSource1.DataSource = typeof(SeguimientoGasto.Gastos);
            // 
            // gastosBindingSource
            // 
            this.gastosBindingSource.DataSource = typeof(SeguimientoGasto.Gastos);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(422, 394);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "USUARIOS";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(422, 633);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 16);
            this.label17.TabIndex = 41;
            this.label17.Text = "GASTOS";
            // 
            // cbTipoGasto
            // 
            this.cbTipoGasto.FormattingEnabled = true;
            this.cbTipoGasto.Items.AddRange(new object[] {
            "traslado",
            "alimentacion",
            "articulos",
            "otros"});
            this.cbTipoGasto.Location = new System.Drawing.Point(781, 74);
            this.cbTipoGasto.Name = "cbTipoGasto";
            this.cbTipoGasto.Size = new System.Drawing.Size(202, 24);
            this.cbTipoGasto.TabIndex = 43;
            // 
            // cbDetalle
            // 
            this.cbDetalle.FormattingEnabled = true;
            this.cbDetalle.Items.AddRange(new object[] {
            "ida trabajo",
            "regreso trabajo",
            "otros"});
            this.cbDetalle.Location = new System.Drawing.Point(781, 106);
            this.cbDetalle.Name = "cbDetalle";
            this.cbDetalle.Size = new System.Drawing.Size(202, 24);
            this.cbDetalle.TabIndex = 44;
            // 
            // rbGastos
            // 
            this.rbGastos.AutoSize = true;
            this.rbGastos.Location = new System.Drawing.Point(754, 38);
            this.rbGastos.Name = "rbGastos";
            this.rbGastos.Size = new System.Drawing.Size(71, 20);
            this.rbGastos.TabIndex = 2;
            this.rbGastos.TabStop = true;
            this.rbGastos.Text = "Gastos";
            this.rbGastos.UseVisualStyleBackColor = true;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataSource = typeof(SeguimientoGasto.Usuarios);
            // 
            // lblFechaGasto
            // 
            this.lblFechaGasto.AutoSize = true;
            this.lblFechaGasto.Location = new System.Drawing.Point(781, 204);
            this.lblFechaGasto.Name = "lblFechaGasto";
            this.lblFechaGasto.Size = new System.Drawing.Size(82, 16);
            this.lblFechaGasto.TabIndex = 45;
            this.lblFechaGasto.Text = "Fecha gasto";
            // 
            // rbBuscar
            // 
            this.rbBuscar.AutoSize = true;
            this.rbBuscar.Location = new System.Drawing.Point(103, 342);
            this.rbBuscar.Name = "rbBuscar";
            this.rbBuscar.Size = new System.Drawing.Size(122, 20);
            this.rbBuscar.TabIndex = 46;
            this.rbBuscar.TabStop = true;
            this.rbBuscar.Text = "Buscar nombre:";
            this.rbBuscar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(781, 233);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(65, 16);
            this.lblUsuario.TabIndex = 47;
            this.lblUsuario.Text = "idUsuario";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 838);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.rbBuscar);
            this.Controls.Add(this.lblFechaGasto);
            this.Controls.Add(this.rbGastos);
            this.Controls.Add(this.cbDetalle);
            this.Controls.Add(this.cbTipoGasto);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvGastos);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvDepto);
            this.Controls.Add(this.txtDepto);
            this.Controls.Add(this.cbDepto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbDepto);
            this.Controls.Add(this.rbUsuarios);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbUsuarios;
        private System.Windows.Forms.RadioButton rbDepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDepto;
        private System.Windows.Forms.TextBox txtDepto;
        private System.Windows.Forms.DataGridView dgvDepto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dgvGastos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbTipoGasto;
        private System.Windows.Forms.ComboBox cbDetalle;
        private System.Windows.Forms.RadioButton rbGastos;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gastosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamentosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuariosBindingSource2;
        private System.Windows.Forms.BindingSource gastosBindingSource1;
        private System.Windows.Forms.Label lblFechaGasto;
        private System.Windows.Forms.RadioButton rbBuscar;
        private System.Windows.Forms.Label lblUsuario;
    }
}