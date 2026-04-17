namespace Capa.Presentacion
{
    partial class ProductosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosFrm));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.btnEliminar = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.btnAgregar = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.btnIrCategoria = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.altoGroupBox3 = new AltoControls.AltoGroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.altoGroupBox1 = new AltoControls.AltoGroupBox();
            this.altoGroupBox2 = new AltoControls.AltoGroupBox();
            this.btnIrClientes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIrUsuarios = new System.Windows.Forms.Button();
            this.btnIrProductos = new System.Windows.Forms.Button();
            this.btnIrReportes = new System.Windows.Forms.Button();
            this.btnIrMovimiento = new System.Windows.Forms.Button();
            this.btnIrInicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.altoGroupBox3.SuspendLayout();
            this.altoGroupBox1.SuspendLayout();
            this.altoGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(428, 318);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 62;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(796, 294);
            this.dgvProductos.TabIndex = 5;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
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
            this.btnLimpiar.Location = new System.Drawing.Point(625, 259);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextColor = System.Drawing.Color.White;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(816, 259);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 40);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(428, 259);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 40);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnIrCategoria
            // 
            this.btnIrCategoria.BackColor = System.Drawing.Color.Navy;
            this.btnIrCategoria.BackgroundColor = System.Drawing.Color.Navy;
            this.btnIrCategoria.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnIrCategoria.BorderRadius = 20;
            this.btnIrCategoria.BorderSize = 0;
            this.btnIrCategoria.FlatAppearance.BorderSize = 0;
            this.btnIrCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrCategoria.ForeColor = System.Drawing.Color.White;
            this.btnIrCategoria.Location = new System.Drawing.Point(1034, 259);
            this.btnIrCategoria.Name = "btnIrCategoria";
            this.btnIrCategoria.Size = new System.Drawing.Size(174, 40);
            this.btnIrCategoria.TabIndex = 9;
            this.btnIrCategoria.Text = "Ir a Categoria";
            this.btnIrCategoria.TextColor = System.Drawing.Color.White;
            this.btnIrCategoria.UseVisualStyleBackColor = false;
            this.btnIrCategoria.Click += new System.EventHandler(this.btnIrCategoria_Click);
            // 
            // altoGroupBox3
            // 
            this.altoGroupBox3.BackColor = System.Drawing.Color.White;
            this.altoGroupBox3.BackgroundColor = System.Drawing.Color.White;
            this.altoGroupBox3.Controls.Add(this.txtPrecio);
            this.altoGroupBox3.Controls.Add(this.label6);
            this.altoGroupBox3.Controls.Add(this.cmbCategoria);
            this.altoGroupBox3.Controls.Add(this.label5);
            this.altoGroupBox3.Controls.Add(this.txtNProducto);
            this.altoGroupBox3.Controls.Add(this.label4);
            this.altoGroupBox3.Controls.Add(this.cmbProveedor);
            this.altoGroupBox3.Controls.Add(this.label3);
            this.altoGroupBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.altoGroupBox3.Location = new System.Drawing.Point(428, 60);
            this.altoGroupBox3.Name = "altoGroupBox3";
            this.altoGroupBox3.Radius = 15;
            this.altoGroupBox3.Size = new System.Drawing.Size(796, 179);
            this.altoGroupBox3.TabIndex = 3;
            this.altoGroupBox3.TitleColor = System.Drawing.Color.Black;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(527, 118);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(185, 34);
            this.txtPrecio.TabIndex = 10;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Precio:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(257, 118);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(176, 36);
            this.cmbCategoria.TabIndex = 8;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Selecciona una Categoria:";
            // 
            // txtNProducto
            // 
            this.txtNProducto.Location = new System.Drawing.Point(606, 36);
            this.txtNProducto.Name = "txtNProducto";
            this.txtNProducto.Size = new System.Drawing.Size(185, 34);
            this.txtNProducto.TabIndex = 6;
            this.txtNProducto.TextChanged += new System.EventHandler(this.txtNProducto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre Producto:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(243, 35);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(176, 36);
            this.cmbProveedor.TabIndex = 2;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecciona un Provedor:";
            // 
            // altoGroupBox1
            // 
            this.altoGroupBox1.BackColor = System.Drawing.Color.Navy;
            this.altoGroupBox1.BackgroundColor = System.Drawing.Color.Navy;
            this.altoGroupBox1.Controls.Add(this.altoGroupBox2);
            this.altoGroupBox1.Controls.Add(this.btnVolver);
            this.altoGroupBox1.Controls.Add(this.label1);
            this.altoGroupBox1.Controls.Add(this.pictureBox1);
            this.altoGroupBox1.Controls.Add(this.btnIrUsuarios);
            this.altoGroupBox1.Controls.Add(this.btnIrProductos);
            this.altoGroupBox1.Controls.Add(this.btnIrReportes);
            this.altoGroupBox1.Controls.Add(this.btnIrMovimiento);
            this.altoGroupBox1.Controls.Add(this.btnIrInicio);
            this.altoGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.altoGroupBox1.Location = new System.Drawing.Point(1, 0);
            this.altoGroupBox1.Name = "altoGroupBox1";
            this.altoGroupBox1.Radius = 15;
            this.altoGroupBox1.Size = new System.Drawing.Size(363, 662);
            this.altoGroupBox1.TabIndex = 1;
            this.altoGroupBox1.TitleColor = System.Drawing.Color.Black;
            // 
            // altoGroupBox2
            // 
            this.altoGroupBox2.BackColor = System.Drawing.Color.Navy;
            this.altoGroupBox2.BackgroundColor = System.Drawing.Color.Navy;
            this.altoGroupBox2.Controls.Add(this.btnIrClientes);
            this.altoGroupBox2.Controls.Add(this.button2);
            this.altoGroupBox2.Controls.Add(this.label2);
            this.altoGroupBox2.Controls.Add(this.pictureBox2);
            this.altoGroupBox2.Controls.Add(this.button3);
            this.altoGroupBox2.Controls.Add(this.button4);
            this.altoGroupBox2.Controls.Add(this.button5);
            this.altoGroupBox2.Controls.Add(this.button6);
            this.altoGroupBox2.Controls.Add(this.button7);
            this.altoGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.altoGroupBox2.Location = new System.Drawing.Point(0, -3);
            this.altoGroupBox2.Name = "altoGroupBox2";
            this.altoGroupBox2.Radius = 15;
            this.altoGroupBox2.Size = new System.Drawing.Size(363, 669);
            this.altoGroupBox2.TabIndex = 7;
            this.altoGroupBox2.TitleColor = System.Drawing.Color.Black;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(10, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 30);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnIrLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(110, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Administrador";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(115, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 111);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(-3, 554);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(363, 61);
            this.button3.TabIndex = 4;
            this.button3.Text = "          🙎‍♂️Usuarios";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnIrUsuarios_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(-3, 457);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(363, 61);
            this.button4.TabIndex = 3;
            this.button4.Text = "          🛒Productos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnIrProductos_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(-3, 402);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(363, 61);
            this.button5.TabIndex = 2;
            this.button5.Text = "          📃Reportes";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnIrReportes_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Navy;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(-3, 345);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(363, 61);
            this.button6.TabIndex = 1;
            this.button6.Text = "          💰Registrar Movimiento";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnIrMovimiento_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Navy;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(-3, 287);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(360, 61);
            this.button7.TabIndex = 0;
            this.button7.Text = "          👤Inicio";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnIrInicio_Click_1);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Navy;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(3, 22);
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
            this.btnIrUsuarios.Location = new System.Drawing.Point(-3, 512);
            this.btnIrUsuarios.Name = "btnIrUsuarios";
            this.btnIrUsuarios.Size = new System.Drawing.Size(363, 61);
            this.btnIrUsuarios.TabIndex = 4;
            this.btnIrUsuarios.Text = "          👥Usuarios";
            this.btnIrUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIrUsuarios.UseVisualStyleBackColor = false;
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
            // 
            // ProductosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 648);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnIrCategoria);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.altoGroupBox3);
            this.Controls.Add(this.altoGroupBox1);
            this.Name = "ProductosFrm";
            this.Text = "ProductosFrm";
            this.Load += new System.EventHandler(this.ProductosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.altoGroupBox3.ResumeLayout(false);
            this.altoGroupBox3.PerformLayout();
            this.altoGroupBox1.ResumeLayout(false);
            this.altoGroupBox1.PerformLayout();
            this.altoGroupBox2.ResumeLayout(false);
            this.altoGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private AltoControls.AltoGroupBox altoGroupBox2;
        private System.Windows.Forms.Button btnIrClientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private AltoControls.AltoGroupBox altoGroupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private CapaPresentacion.Buttons_Style.ButtonRound btnIrCategoria;
        private CapaPresentacion.Buttons_Style.ButtonRound btnLimpiar;
        private CapaPresentacion.Buttons_Style.ButtonRound btnEliminar;
        private CapaPresentacion.Buttons_Style.ButtonRound btnAgregar;
    }
}