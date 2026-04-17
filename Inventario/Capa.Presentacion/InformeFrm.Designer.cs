namespace Capa.Presentacion
{
    partial class InformeFrm
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
            this.RVMovimiento = new Microsoft.Reporting.WinForms.ReportViewer();
            this.inventarioDBDataSet = new Capa.Presentacion.InventarioDBDataSet();
            this.inventarioDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_Reporte_Movimiento_Por_IdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Reporte_Movimiento_Por_IdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RVMovimiento
            // 
            reportDataSource1.Name = "DataSetMovimiento";
            reportDataSource1.Value = this.inventarioDBDataSetBindingSource;
            this.RVMovimiento.LocalReport.DataSources.Add(reportDataSource1);
            this.RVMovimiento.LocalReport.ReportEmbeddedResource = "Capa.Presentacion.Reportes.ReporteMovimiento.rdlc";
            this.RVMovimiento.Location = new System.Drawing.Point(0, 1);
            this.RVMovimiento.Name = "RVMovimiento";
            this.RVMovimiento.ServerReport.BearerToken = null;
            this.RVMovimiento.Size = new System.Drawing.Size(1927, 1049);
            this.RVMovimiento.TabIndex = 0;
            // 
            // inventarioDBDataSet
            // 
            this.inventarioDBDataSet.DataSetName = "InventarioDBDataSet";
            this.inventarioDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioDBDataSetBindingSource
            // 
            this.inventarioDBDataSetBindingSource.DataSource = this.inventarioDBDataSet;
            this.inventarioDBDataSetBindingSource.Position = 0;
            // 
            // SP_Reporte_Movimiento_Por_IdBindingSource
            // 
            this.SP_Reporte_Movimiento_Por_IdBindingSource.DataMember = "SP_Reporte_Movimiento_Por_Id";
            this.SP_Reporte_Movimiento_Por_IdBindingSource.DataSource = this.inventarioDBDataSet;
            // 
            // InformeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.RVMovimiento);
            this.Name = "InformeFrm";
            this.Text = "InformeFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InformeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_Reporte_Movimiento_Por_IdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVMovimiento;
        private System.Windows.Forms.BindingSource inventarioDBDataSetBindingSource;
        private InventarioDBDataSet inventarioDBDataSet;
        private System.Windows.Forms.BindingSource SP_Reporte_Movimiento_Por_IdBindingSource;
    }
}