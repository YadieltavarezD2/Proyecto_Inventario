using System.Windows.Forms;

namespace Capa.Presentacion
{
    partial class MovimientoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimientoFrm));
            this.dgvMovimiento = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnX = new System.Windows.Forms.Button();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new AltoControls.AltoTextBox();
            this.btnCancelar = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.btnGuardar = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.altoGroupBox2 = new AltoControls.AltoGroupBox();
            this.cmbClienteProveedor = new System.Windows.Forms.ComboBox();
            this.lblNumeroMovimiento = new System.Windows.Forms.Label();
            this.lblRespuestaCP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClienteProveedor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMovimiento = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).BeginInit();
            this.altoGroupBox2.SuspendLayout();
            this.altoGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovimiento
            // 
            this.dgvMovimiento.AllowUserToAddRows = false;
            this.dgvMovimiento.AllowUserToDeleteRows = false;
            this.dgvMovimiento.AllowUserToResizeColumns = false;
            this.dgvMovimiento.AllowUserToResizeRows = false;
            this.dgvMovimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovimiento.BackgroundColor = System.Drawing.Color.White;
            this.dgvMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimiento.Location = new System.Drawing.Point(396, 358);
            this.dgvMovimiento.Name = "dgvMovimiento";
            this.dgvMovimiento.ReadOnly = true;
            this.dgvMovimiento.RowHeadersVisible = false;
            this.dgvMovimiento.RowHeadersWidth = 62;
            this.dgvMovimiento.RowTemplate.Height = 28;
            this.dgvMovimiento.Size = new System.Drawing.Size(597, 278);
            this.dgvMovimiento.TabIndex = 2;
            this.dgvMovimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimiento_CellClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // btnCheck
            // 
            this.btnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.BackgroundImage")));
            this.btnCheck.Enabled = false;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.Color.Lime;
            this.btnCheck.Location = new System.Drawing.Point(1030, 274);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(60, 35);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(396, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(728, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cantidad:";
            // 
            // btnX
            // 
            this.btnX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnX.BackgroundImage")));
            this.btnX.Enabled = false;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.Red;
            this.btnX.Location = new System.Drawing.Point(1131, 274);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(56, 35);
            this.btnX.TabIndex = 14;
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // cmbProductos
            // 
            this.cmbProductos.BackColor = System.Drawing.Color.White;
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.DropDownWidth = 120;
            this.cmbProductos.Enabled = false;
            this.cmbProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(499, 274);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(223, 36);
            this.cmbProductos.TabIndex = 16;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackgroundColor = System.Drawing.Color.White;
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCantidad.Location = new System.Drawing.Point(822, 274);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Placeholder = "Aquí...";
            this.txtCantidad.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtCantidad.Radius = 10;
            this.txtCantidad.Size = new System.Drawing.Size(171, 42);
            this.txtCantidad.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Red;
            this.btnCancelar.BorderColor = System.Drawing.Color.Red;
            this.btnCancelar.BorderRadius = 40;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(1023, 567);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGuardar.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.BorderRadius = 40;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1023, 440);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // altoGroupBox2
            // 
            this.altoGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.altoGroupBox2.BackColor = System.Drawing.Color.White;
            this.altoGroupBox2.BackgroundColor = System.Drawing.Color.White;
            this.altoGroupBox2.Controls.Add(this.cmbClienteProveedor);
            this.altoGroupBox2.Controls.Add(this.lblNumeroMovimiento);
            this.altoGroupBox2.Controls.Add(this.lblRespuestaCP);
            this.altoGroupBox2.Controls.Add(this.label6);
            this.altoGroupBox2.Controls.Add(this.lblFecha);
            this.altoGroupBox2.Controls.Add(this.label4);
            this.altoGroupBox2.Controls.Add(this.lblClienteProveedor);
            this.altoGroupBox2.Controls.Add(this.label2);
            this.altoGroupBox2.Controls.Add(this.cmbMovimiento);
            this.altoGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.altoGroupBox2.Location = new System.Drawing.Point(396, 22);
            this.altoGroupBox2.Name = "altoGroupBox2";
            this.altoGroupBox2.Radius = 15;
            this.altoGroupBox2.Size = new System.Drawing.Size(815, 203);
            this.altoGroupBox2.TabIndex = 6;
            this.altoGroupBox2.TitleColor = System.Drawing.Color.Black;
            this.altoGroupBox2.Click += new System.EventHandler(this.altoGroupBox2_Click);
            // 
            // cmbClienteProveedor
            // 
            this.cmbClienteProveedor.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbClienteProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClienteProveedor.DropDownWidth = 120;
            this.cmbClienteProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClienteProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbClienteProveedor.FormattingEnabled = true;
            this.cmbClienteProveedor.Location = new System.Drawing.Point(141, 130);
            this.cmbClienteProveedor.Name = "cmbClienteProveedor";
            this.cmbClienteProveedor.Size = new System.Drawing.Size(164, 36);
            this.cmbClienteProveedor.TabIndex = 17;
            this.cmbClienteProveedor.Visible = false;
            this.cmbClienteProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbClienteProveedor_SelectedIndexChanged);
            // 
            // lblNumeroMovimiento
            // 
            this.lblNumeroMovimiento.AutoSize = true;
            this.lblNumeroMovimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNumeroMovimiento.Location = new System.Drawing.Point(600, 83);
            this.lblNumeroMovimiento.Name = "lblNumeroMovimiento";
            this.lblNumeroMovimiento.Size = new System.Drawing.Size(148, 28);
            this.lblNumeroMovimiento.TabIndex = 15;
            this.lblNumeroMovimiento.Text = "_________________";
            // 
            // lblRespuestaCP
            // 
            this.lblRespuestaCP.AutoSize = true;
            this.lblRespuestaCP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRespuestaCP.Location = new System.Drawing.Point(211, 130);
            this.lblRespuestaCP.Name = "lblRespuestaCP";
            this.lblRespuestaCP.Size = new System.Drawing.Size(0, 28);
            this.lblRespuestaCP.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(540, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "No.";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(603, 38);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 28);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(531, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha:";
            // 
            // lblClienteProveedor
            // 
            this.lblClienteProveedor.AutoSize = true;
            this.lblClienteProveedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClienteProveedor.Location = new System.Drawing.Point(21, 130);
            this.lblClienteProveedor.Name = "lblClienteProveedor";
            this.lblClienteProveedor.Size = new System.Drawing.Size(76, 28);
            this.lblClienteProveedor.TabIndex = 8;
            this.lblClienteProveedor.Text = "Cliente:";
            this.lblClienteProveedor.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(18, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo de Movimiento:";
            // 
            // cmbMovimiento
            // 
            this.cmbMovimiento.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovimiento.DropDownWidth = 120;
            this.cmbMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMovimiento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMovimiento.ForeColor = System.Drawing.Color.Black;
            this.cmbMovimiento.FormattingEnabled = true;
            this.cmbMovimiento.Location = new System.Drawing.Point(218, 30);
            this.cmbMovimiento.Name = "cmbMovimiento";
            this.cmbMovimiento.Size = new System.Drawing.Size(120, 36);
            this.cmbMovimiento.TabIndex = 6;
            this.cmbMovimiento.SelectedIndexChanged += new System.EventHandler(this.cmbMovimiento_SelectedIndexChanged);
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
            this.altoGroupBox1.Location = new System.Drawing.Point(1, -20);
            this.altoGroupBox1.Name = "altoGroupBox1";
            this.altoGroupBox1.Radius = 15;
            this.altoGroupBox1.Size = new System.Drawing.Size(363, 682);
            this.altoGroupBox1.TabIndex = 1;
            this.altoGroupBox1.TitleColor = System.Drawing.Color.Black;
            // 
            // btnIrClientes
            // 
            this.btnIrClientes.BackColor = System.Drawing.Color.Navy;
            this.btnIrClientes.FlatAppearance.BorderSize = 0;
            this.btnIrClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrClientes.ForeColor = System.Drawing.Color.White;
            this.btnIrClientes.Location = new System.Drawing.Point(0, 509);
            this.btnIrClientes.Name = "btnIrClientes";
            this.btnIrClientes.Size = new System.Drawing.Size(363, 61);
            this.btnIrClientes.TabIndex = 7;
            this.btnIrClientes.Text = "         👥Clientes";
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
            this.btnVolver.Location = new System.Drawing.Point(11, 32);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(46, 30);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnIrLogin_Click);
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
            this.btnIrUsuarios.Location = new System.Drawing.Point(-3, 556);
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
            // MovimientoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 648);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.altoGroupBox2);
            this.Controls.Add(this.dgvMovimiento);
            this.Controls.Add(this.altoGroupBox1);
            this.Name = "MovimientoFrm";
            this.Text = "MovimientoFrm";
            this.Load += new System.EventHandler(this.MovimientoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).EndInit();
            this.altoGroupBox2.ResumeLayout(false);
            this.altoGroupBox2.PerformLayout();
            this.altoGroupBox1.ResumeLayout(false);
            this.altoGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltoControls.AltoGroupBox altoGroupBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIrUsuarios;
        private System.Windows.Forms.Button btnIrProductos;
        private System.Windows.Forms.Button btnIrReportes;
        private System.Windows.Forms.Button btnIrMovimiento;
        private System.Windows.Forms.Button btnIrInicio;
        private System.Windows.Forms.DataGridView dgvMovimiento;
        private AltoControls.AltoGroupBox altoGroupBox2;
        private System.Windows.Forms.Label lblClienteProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMovimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblRespuestaCP;
        private System.Windows.Forms.Label lblNumeroMovimiento;
        private CapaPresentacion.Buttons_Style.ButtonRound btnGuardar;
        private CapaPresentacion.Buttons_Style.ButtonRound btnCancelar;
        private Button btnCheck;
        private AltoControls.AltoTextBox txtCantidad;
        private Label label3;
        private Label label8;
        private Button btnX;
        private ComboBox cmbProductos;
        private ComboBox cmbClienteProveedor;
        private Button btnIrClientes;
    }
}