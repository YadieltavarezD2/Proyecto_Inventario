namespace Capa.Presentacion
{
    partial class InicioFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioFrm));
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.altoGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.altoGroupBox1.Location = new System.Drawing.Point(-8, -6);
            this.altoGroupBox1.Name = "altoGroupBox1";
            this.altoGroupBox1.Radius = 15;
            this.altoGroupBox1.Size = new System.Drawing.Size(373, 669);
            this.altoGroupBox1.TabIndex = 0;
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
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.Presentacion.Reportes.ReporteGrafico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(358, -30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1106, 677);
            this.reportViewer1.TabIndex = 1;
            // 
            // InicioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 648);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.altoGroupBox1);
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.Name = "InicioFrm";
            this.Text = "InicioFrm";
            this.Load += new System.EventHandler(this.InicioFrm_Load);
            this.altoGroupBox1.ResumeLayout(false);
            this.altoGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AltoControls.AltoGroupBox altoGroupBox1;
        private System.Windows.Forms.Button btnIrUsuarios;
        private System.Windows.Forms.Button btnIrProductos;
        private System.Windows.Forms.Button btnIrReportes;
        private System.Windows.Forms.Button btnIrMovimiento;
        private System.Windows.Forms.Button btnIrInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnIrClientes;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}