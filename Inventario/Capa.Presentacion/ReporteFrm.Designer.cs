namespace Capa.Presentacion
{
    partial class ReporteFrm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteFrm));
            this.inventarioDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDBDataSet = new Capa.Presentacion.InventarioDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.altoGroupBox2 = new AltoControls.AltoGroupBox();
            this.btnVer = new CapaPresentacion.Buttons_Style.ButtonRound();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.altoGroupBox1 = new AltoControls.AltoGroupBox();
            this.altoGroupBox4 = new AltoControls.AltoGroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSet)).BeginInit();
            this.altoGroupBox2.SuspendLayout();
            this.altoGroupBox1.SuspendLayout();
            this.altoGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inventarioDBDataSetBindingSource
            // 
            this.inventarioDBDataSetBindingSource.DataSource = this.inventarioDBDataSet;
            this.inventarioDBDataSetBindingSource.Position = 0;
            // 
            // inventarioDBDataSet
            // 
            this.inventarioDBDataSet.DataSetName = "InventarioDBDataSet";
            this.inventarioDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetMovimiento";
            reportDataSource1.Value = this.inventarioDBDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa.Presentacion.Reportes.ReporteMovimiento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(383, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(427, 601);
            this.reportViewer1.TabIndex = 2;
            // 
            // altoGroupBox2
            // 
            this.altoGroupBox2.BackColor = System.Drawing.Color.White;
            this.altoGroupBox2.BackgroundColor = System.Drawing.Color.White;
            this.altoGroupBox2.Controls.Add(this.btnVer);
            this.altoGroupBox2.Controls.Add(this.label3);
            this.altoGroupBox2.Controls.Add(this.comboBox1);
            this.altoGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.altoGroupBox2.Location = new System.Drawing.Point(895, 21);
            this.altoGroupBox2.Name = "altoGroupBox2";
            this.altoGroupBox2.Radius = 15;
            this.altoGroupBox2.Size = new System.Drawing.Size(377, 195);
            this.altoGroupBox2.TabIndex = 3;
            this.altoGroupBox2.TitleColor = System.Drawing.Color.Black;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVer.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnVer.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnVer.BorderRadius = 40;
            this.btnVer.BorderSize = 0;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.ForeColor = System.Drawing.Color.White;
            this.btnVer.Location = new System.Drawing.Point(216, 124);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(150, 40);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.TextColor = System.Drawing.Color.White;
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "No. Movimiento:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 36);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // altoGroupBox1
            // 
            this.altoGroupBox1.BackColor = System.Drawing.Color.Navy;
            this.altoGroupBox1.BackgroundColor = System.Drawing.Color.Navy;
            this.altoGroupBox1.Controls.Add(this.altoGroupBox4);
            this.altoGroupBox1.Controls.Add(this.btnVolver);
            this.altoGroupBox1.Controls.Add(this.label1);
            this.altoGroupBox1.Controls.Add(this.pictureBox1);
            this.altoGroupBox1.Controls.Add(this.btnIrUsuarios);
            this.altoGroupBox1.Controls.Add(this.btnIrProductos);
            this.altoGroupBox1.Controls.Add(this.btnIrReportes);
            this.altoGroupBox1.Controls.Add(this.btnIrMovimiento);
            this.altoGroupBox1.Controls.Add(this.btnIrInicio);
            this.altoGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.altoGroupBox1.Location = new System.Drawing.Point(1, -8);
            this.altoGroupBox1.Name = "altoGroupBox1";
            this.altoGroupBox1.Radius = 15;
            this.altoGroupBox1.Size = new System.Drawing.Size(363, 671);
            this.altoGroupBox1.TabIndex = 1;
            this.altoGroupBox1.TitleColor = System.Drawing.Color.Black;
            // 
            // altoGroupBox4
            // 
            this.altoGroupBox4.BackColor = System.Drawing.Color.Navy;
            this.altoGroupBox4.BackgroundColor = System.Drawing.Color.Navy;
            this.altoGroupBox4.Controls.Add(this.btnIrClientes);
            this.altoGroupBox4.Controls.Add(this.button2);
            this.altoGroupBox4.Controls.Add(this.label2);
            this.altoGroupBox4.Controls.Add(this.pictureBox2);
            this.altoGroupBox4.Controls.Add(this.button3);
            this.altoGroupBox4.Controls.Add(this.button4);
            this.altoGroupBox4.Controls.Add(this.button5);
            this.altoGroupBox4.Controls.Add(this.button6);
            this.altoGroupBox4.Controls.Add(this.button7);
            this.altoGroupBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.altoGroupBox4.Location = new System.Drawing.Point(0, 1);
            this.altoGroupBox4.Name = "altoGroupBox4";
            this.altoGroupBox4.Radius = 15;
            this.altoGroupBox4.Size = new System.Drawing.Size(363, 669);
            this.altoGroupBox4.TabIndex = 7;
            this.altoGroupBox4.TitleColor = System.Drawing.Color.Black;
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
            // ReporteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 648);
            this.Controls.Add(this.altoGroupBox2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.altoGroupBox1);
            this.Name = "ReporteFrm";
            this.Text = "ReporteFrm";
            this.Load += new System.EventHandler(this.ReporteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSet)).EndInit();
            this.altoGroupBox2.ResumeLayout(false);
            this.altoGroupBox2.PerformLayout();
            this.altoGroupBox1.ResumeLayout(false);
            this.altoGroupBox1.PerformLayout();
            this.altoGroupBox4.ResumeLayout(false);
            this.altoGroupBox4.PerformLayout();
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
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AltoControls.AltoGroupBox altoGroupBox2;
        private AltoControls.AltoGroupBox altoGroupBox4;
        private System.Windows.Forms.Button btnIrClientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox comboBox1;
        private CapaPresentacion.Buttons_Style.ButtonRound btnVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource inventarioDBDataSetBindingSource;
        private InventarioDBDataSet inventarioDBDataSet;
    }
}