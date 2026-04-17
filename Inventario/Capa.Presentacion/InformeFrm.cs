using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class InformeFrm : Form
    {

        int idmovimieno;

        public InformeFrm(int id)
        {
            InitializeComponent();
            idmovimieno = id;
        }

        private void InformeFrm_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            var ds = new InventarioDBDataSet();

            var ta = new InventarioDBDataSetTableAdapters
                .SP_Reporte_Movimiento_Por_IdTableAdapter();

            ds.EnforceConstraints = false;

            ta.Fill(ds.SP_Reporte_Movimiento_Por_Id, idmovimieno);

            ReportDataSource rds = new ReportDataSource(
                "DataSetMovimiento", // 🔥 debe ser EXACTO al RDLC
                (DataTable)ds.SP_Reporte_Movimiento_Por_Id
            );

            RVMovimiento.LocalReport.DataSources.Clear();
            RVMovimiento.LocalReport.DataSources.Add(rds);
            RVMovimiento.ZoomMode = ZoomMode.PageWidth;
            RVMovimiento.RefreshReport();
        }
    }
}

