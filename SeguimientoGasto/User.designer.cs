namespace SeguimientoGasto
{
    partial class User
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
            this.cbDetalle = new System.Windows.Forms.ComboBox();
            this.cbTipoGasto = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.gastosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaGastoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDetalle
            // 
            this.cbDetalle.FormattingEnabled = true;
            this.cbDetalle.Items.AddRange(new object[] {
            "ida trabajo",
            "regreso trabajo",
            "otros"});
            this.cbDetalle.Location = new System.Drawing.Point(238, 57);
            this.cbDetalle.Name = "cbDetalle";
            this.cbDetalle.Size = new System.Drawing.Size(202, 24);
            this.cbDetalle.TabIndex = 56;
            // 
            // cbTipoGasto
            // 
            this.cbTipoGasto.FormattingEnabled = true;
            this.cbTipoGasto.Items.AddRange(new object[] {
            "traslado",
            "alimentacion",
            "articulos",
            "otros"});
            this.cbTipoGasto.Location = new System.Drawing.Point(238, 25);
            this.cbTipoGasto.Name = "cbTipoGasto";
            this.cbTipoGasto.Size = new System.Drawing.Size(202, 24);
            this.cbTipoGasto.TabIndex = 55;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(238, 118);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(202, 22);
            this.txtMonto.TabIndex = 52;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(238, 87);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(202, 22);
            this.txtDescripcion.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(140, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = "Usuario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(140, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "Monto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "Descripcion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(140, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Detalle:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Tipo gasto:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(533, 146);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(533, 87);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 58;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(533, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 57;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AutoGenerateColumns = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGastoDataGridViewTextBoxColumn,
            this.tipoGastoDataGridViewTextBoxColumn,
            this.detalleDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.fechaGastoDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.usuariosDataGridViewTextBoxColumn});
            this.dgvUsuario.DataSource = this.gastosBindingSource;
            this.dgvUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUsuario.Location = new System.Drawing.Point(0, 264);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.RowHeadersWidth = 51;
            this.dgvUsuario.RowTemplate.Height = 24;
            this.dgvUsuario.Size = new System.Drawing.Size(800, 186);
            this.dgvUsuario.TabIndex = 61;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(238, 152);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 16);
            this.lblUsuario.TabIndex = 62;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(280, 219);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(328, 22);
            this.txtBuscar.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(140, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 16);
            this.label15.TabIndex = 63;
            this.label15.Text = "Buscar tipo gasto:";
            // 
            // gastosBindingSource
            // 
            this.gastosBindingSource.DataSource = typeof(SeguimientoGasto.Gastos);
            // 
            // idGastoDataGridViewTextBoxColumn
            // 
            this.idGastoDataGridViewTextBoxColumn.DataPropertyName = "idGasto";
            this.idGastoDataGridViewTextBoxColumn.HeaderText = "idGasto";
            this.idGastoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGastoDataGridViewTextBoxColumn.Name = "idGastoDataGridViewTextBoxColumn";
            this.idGastoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoGastoDataGridViewTextBoxColumn
            // 
            this.tipoGastoDataGridViewTextBoxColumn.DataPropertyName = "tipoGasto";
            this.tipoGastoDataGridViewTextBoxColumn.HeaderText = "tipoGasto";
            this.tipoGastoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoGastoDataGridViewTextBoxColumn.Name = "tipoGastoDataGridViewTextBoxColumn";
            this.tipoGastoDataGridViewTextBoxColumn.Width = 125;
            // 
            // detalleDataGridViewTextBoxColumn
            // 
            this.detalleDataGridViewTextBoxColumn.DataPropertyName = "detalle";
            this.detalleDataGridViewTextBoxColumn.HeaderText = "detalle";
            this.detalleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.detalleDataGridViewTextBoxColumn.Name = "detalleDataGridViewTextBoxColumn";
            this.detalleDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechaGastoDataGridViewTextBoxColumn
            // 
            this.fechaGastoDataGridViewTextBoxColumn.DataPropertyName = "fechaGasto";
            this.fechaGastoDataGridViewTextBoxColumn.HeaderText = "fechaGasto";
            this.fechaGastoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaGastoDataGridViewTextBoxColumn.Name = "fechaGastoDataGridViewTextBoxColumn";
            this.fechaGastoDataGridViewTextBoxColumn.Width = 125;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuariosDataGridViewTextBoxColumn
            // 
            this.usuariosDataGridViewTextBoxColumn.DataPropertyName = "Usuarios";
            this.usuariosDataGridViewTextBoxColumn.HeaderText = "Usuarios";
            this.usuariosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuariosDataGridViewTextBoxColumn.Name = "usuariosDataGridViewTextBoxColumn";
            this.usuariosDataGridViewTextBoxColumn.Width = 125;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbDetalle);
            this.Controls.Add(this.cbTipoGasto);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDetalle;
        private System.Windows.Forms.ComboBox cbTipoGasto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaGastoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gastosBindingSource;
    }
}