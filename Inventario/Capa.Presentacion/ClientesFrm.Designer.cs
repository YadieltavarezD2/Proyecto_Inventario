namespace Capa.Presentacion
{
    partial class ClientesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesFrm));
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.btnLimpiar = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.btnIrProveedores = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.btnAgregar = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.altoGroupBox3 = new AltoControls.AltoGroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.altoGroupBox1 = new AltoControls.AltoGroupBox();
            this.btnIrClientes = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIrUsuarios = new System.Windows.Forms.Button();
            this.btnIrProductos = new System.Windows.Forms.Button();
            this.btnIrReportes = new System.Windows.Forms.Button();
            this.btnIrMovimiento = new System.Windows.Forms.Button();
            this.btnIrInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.altoGroupBox3.SuspendLayout();
            this.altoGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.ColumnHeadersVisible = false;
            this.dgvClientes.Location = new System.Drawing.Point(403, 340);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.Size = new System.Drawing.Size(814, 294);
            this.dgvClientes.TabIndex = 6;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.Red;
            this.btnEliminar.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnEliminar.BorderRadius = 40;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(786, 282);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Green;
            this.btnLimpiar.BackgroundColor = System.Drawing.Color.Green;
            this.btnLimpiar.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnLimpiar.BorderRadius = 40;
            this.btnLimpiar.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(591, 279);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnIrProveedores
            // 
            this.btnIrProveedores.BackColor = System.Drawing.Color.Navy;
            this.btnIrProveedores.BackgroundColor = System.Drawing.Color.Navy;
            this.btnIrProveedores.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnIrProveedores.BorderRadius = 20;
            this.btnIrProveedores.BorderSize = 0;
            this.btnIrProveedores.FlatAppearance.BorderSize = 0;
            this.btnIrProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrProveedores.ForeColor = System.Drawing.Color.White;
            this.btnIrProveedores.Location = new System.Drawing.Point(1067, 279);
            this.btnIrProveedores.Name = "btnIrProveedores";
            this.btnIrProveedores.Size = new System.Drawing.Size(150, 40);
            this.btnIrProveedores.TabIndex = 8;
            this.btnIrProveedores.Text = "Proveedores";
            this.btnIrProveedores.TextColor = System.Drawing.Color.White;
            this.btnIrProveedores.UseVisualStyleBackColor = false;
            this.btnIrProveedores.Click += new System.EventHandler(this.btnIrProveedores_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnAgregar.BorderRadius = 40;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Location = new System.Drawing.Point(403, 279);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 40);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // altoGroupBox3
            // 
            this.altoGroupBox3.BackColor = System.Drawing.Color.White;
            this.altoGroupBox3.BackgroundColor = System.Drawing.Color.White;
            this.altoGroupBox3.Controls.Add(this.txtEmail);
            this.altoGroupBox3.Controls.Add(this.label2);
            this.altoGroupBox3.Controls.Add(this.txtTelefono);
            this.altoGroupBox3.Controls.Add(this.txtNombreCliente);
            this.altoGroupBox3.Controls.Add(this.txtDireccion);
            this.altoGroupBox3.Controls.Add(this.label6);
            this.altoGroupBox3.Controls.Add(this.label5);
            this.altoGroupBox3.Controls.Add(this.txtCedula);
            this.altoGroupBox3.Controls.Add(this.label4);
            this.altoGroupBox3.Controls.Add(this.label3);
            this.altoGroupBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.altoGroupBox3.Location = new System.Drawing.Point(403, 17);
            this.altoGroupBox3.Name = "altoGroupBox3";
            this.altoGroupBox3.Radius = 15;
            this.altoGroupBox3.Size = new System.Drawing.Size(741, 222);
            this.altoGroupBox3.TabIndex = 7;
            this.altoGroupBox3.TitleColor = System.Drawing.Color.Black;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(603, 34);
            this.txtEmail.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(125, 115);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(185, 34);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(180, 41);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(185, 34);
            this.txtNombreCliente.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(462, 114);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(185, 34);
            this.txtDireccion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Direccion:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefono:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(536, 38);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(185, 34);
            this.txtCedula.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cedula o RNC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Cliente:";
            // 
            // altoGroupBox1
            // 
            this.altoGroupBox1.BackColor = System.Drawing.Color.Navy;
            this.altoGroupBox1.BackgroundColor = System.Drawing.Color.Navy;
            this.altoGroupBox1.Controls.Add(this.btnIrClientes);
            this.altoGroupBox1.Controls.Add(this.btnVolver);
            this.altoGroupBox1.Controls.Add(this.label1);
            this.altoGroupBox1.Controls.Add(this.pictureBox1);
            this.altoGroupBox1.Controls.Add(this.btnIrUsuarios);
            this.altoGroupBox1.Controls.Add(this.btnIrProductos);
            this.altoGroupBox1.Controls.Add(this.btnIrReportes);
            this.altoGroupBox1.Controls.Add(this.btnIrMovimiento);
            this.altoGroupBox1.Controls.Add(this.btnIrInicio);
            this.altoGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.altoGroupBox1.Location = new System.Drawing.Point(1, -5);
            this.altoGroupBox1.Name = "altoGroupBox1";
            this.altoGroupBox1.Radius = 15;
            this.altoGroupBox1.Size = new System.Drawing.Size(363, 674);
            this.altoGroupBox1.TabIndex = 1;
            this.altoGroupBox1.TitleColor = System.Drawing.Color.Black;
            // 
            // btnIrClientes
            // 
            this.btnIrClientes.BackColor = System.Drawing.Color.Navy;
            this.btnIrClientes.FlatAppearance.BorderSize = 0;
            this.btnIrClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrClientes.ForeColor = System.Drawing.Color.White;
            this.btnIrClientes.Location = new System.Drawing.Point(-3, 507);
            this.btnIrClientes.Name = "btnIrClientes";
            this.btnIrClientes.Size = new System.Drawing.Size(363, 61);
            this.btnIrClientes.TabIndex = 7;
            this.btnIrClientes.Text = "          👥Clientes";
            this.btnIrClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrClientes.UseVisualStyleBackColor = false;
            this.btnIrClientes.Click += new System.EventHandler(this.btnIrClientes_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Navy;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(10, 22);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(46, 30);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administrador";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 111);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnIrUsuarios
            // 
            this.btnIrUsuarios.BackColor = System.Drawing.Color.Navy;
            this.btnIrUsuarios.FlatAppearance.BorderSize = 0;
            this.btnIrUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnIrUsuarios.Location = new System.Drawing.Point(-3, 554);
            this.btnIrUsuarios.Name = "btnIrUsuarios";
            this.btnIrUsuarios.Size = new System.Drawing.Size(363, 61);
            this.btnIrUsuarios.TabIndex = 4;
            this.btnIrUsuarios.Text = "          🙎‍♂️Usuarios";
            this.btnIrUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrUsuarios.UseVisualStyleBackColor = false;
            this.btnIrUsuarios.Click += new System.EventHandler(this.btnIrUsuarios_Click);
            // 
            // btnIrProductos
            // 
            this.btnIrProductos.BackColor = System.Drawing.Color.Navy;
            this.btnIrProductos.FlatAppearance.BorderSize = 0;
            this.btnIrProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrProductos.ForeColor = System.Drawing.Color.White;
            this.btnIrProductos.Location = new System.Drawing.Point(-3, 457);
            this.btnIrProductos.Name = "btnIrProductos";
            this.btnIrProductos.Size = new System.Drawing.Size(363, 61);
            this.btnIrProductos.TabIndex = 3;
            this.btnIrProductos.Text = "          🛒Productos";
            this.btnIrProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrProductos.UseVisualStyleBackColor = false;
            this.btnIrProductos.Click += new System.EventHandler(this.btnIrProductos_Click);
            // 
            // btnIrReportes
            // 
            this.btnIrReportes.BackColor = System.Drawing.Color.Navy;
            this.btnIrReportes.FlatAppearance.BorderSize = 0;
            this.btnIrReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrReportes.ForeColor = System.Drawing.Color.White;
            this.btnIrReportes.Location = new System.Drawing.Point(-3, 402);
            this.btnIrReportes.Name = "btnIrReportes";
            this.btnIrReportes.Size = new System.Drawing.Size(363, 61);
            this.btnIrReportes.TabIndex = 2;
            this.btnIrReportes.Text = "          📃Reportes";
            this.btnIrReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrReportes.UseVisualStyleBackColor = false;
            this.btnIrReportes.Click += new System.EventHandler(this.btnIrReportes_Click);
            // 
            // btnIrMovimiento
            // 
            this.btnIrMovimiento.BackColor = System.Drawing.Color.Navy;
            this.btnIrMovimiento.FlatAppearance.BorderSize = 0;
            this.btnIrMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrMovimiento.ForeColor = System.Drawing.Color.White;
            this.btnIrMovimiento.Location = new System.Drawing.Point(-3, 345);
            this.btnIrMovimiento.Name = "btnIrMovimiento";
            this.btnIrMovimiento.Size = new System.Drawing.Size(363, 61);
            this.btnIrMovimiento.TabIndex = 1;
            this.btnIrMovimiento.Text = "          💰Registrar Movimiento";
            this.btnIrMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrMovimiento.UseVisualStyleBackColor = false;
            this.btnIrMovimiento.Click += new System.EventHandler(this.btnIrMovimiento_Click);
            // 
            // btnIrInicio
            // 
            this.btnIrInicio.BackColor = System.Drawing.Color.Navy;
            this.btnIrInicio.FlatAppearance.BorderSize = 0;
            this.btnIrInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrInicio.ForeColor = System.Drawing.Color.White;
            this.btnIrInicio.Location = new System.Drawing.Point(-3, 287);
            this.btnIrInicio.Name = "btnIrInicio";
            this.btnIrInicio.Size = new System.Drawing.Size(360, 61);
            this.btnIrInicio.TabIndex = 0;
            this.btnIrInicio.Text = "          👤Inicio";
            this.btnIrInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrInicio.UseVisualStyleBackColor = false;
            this.btnIrInicio.Click += new System.EventHandler(this.btnIrInicio_Click_1);
            // 
            // ClientesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 641);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnIrProveedores);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.altoGroupBox3);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.altoGroupBox1);
            this.Name = "ClientesFrm";
            this.Text = "ClientesFrm";
            this.Load += new System.EventHandler(this.ClientesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.altoGroupBox3.ResumeLayout(false);
            this.altoGroupBox3.PerformLayout();
            this.altoGroupBox1.ResumeLayout(false);
            this.altoGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AltoControls.AltoGroupBox altoGroupBox1;
        private System.Windows.Forms.Button btnIrClientes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIrUsuarios;
        private System.Windows.Forms.Button btnIrProductos;
        private System.Windows.Forms.Button btnIrReportes;
        private System.Windows.Forms.Button btnIrMovimiento;
        private System.Windows.Forms.Button btnIrInicio;
        private System.Windows.Forms.DataGridView dgvClientes;
        private AltoControls.AltoGroupBox altoGroupBox3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private CapaPresentacion.Buttons_Style.ButtonRound btnIrProveedores;
        private CapaPresentacion.Buttons_Style.ButtonRound btnLimpiar;
        private CapaPresentacion.Buttons_Style.ButtonRound btnEliminar;
        private CapaPresentacion.Buttons_Style.ButtonRound btnAgregar;
    }
}