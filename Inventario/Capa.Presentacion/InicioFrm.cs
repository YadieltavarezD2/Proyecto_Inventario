using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Capa.Presentacion
{
    public partial class InicioFrm : Form
    {
        int idRol;
        int idUsuario;

        public InicioFrm(int rol,int Usuario)
        {
            InitializeComponent();
            idRol = rol;
            idUsuario = Usuario;
        }

        //barra de nav
        private void btnIrLogin_Click(object sender, EventArgs e)
        {
            LoginFrm i = new LoginFrm();
            i.Show();
            this.Hide();
        }

        // ⚠️ este botón realmente no hace falta, pero si lo dejas:
        private void btnIrInicio_Click_1(object sender, EventArgs e)
        {
            InicioFrm i = new InicioFrm(idRol, idUsuario);
            i.Show();
            this.Hide();
        }

        private void btnIrMovimiento_Click(object sender, EventArgs e)
        {
            MovimientoFrm M = new MovimientoFrm(idRol, idUsuario);
            M.Show();
            this.Hide();
        }

        private void btnIrReportes_Click(object sender, EventArgs e)
        {
            ReporteFrm M = new ReporteFrm(idRol, idUsuario);
            M.Show();
            this.Hide();
        }

        private void btnIrProductos_Click(object sender, EventArgs e)
        {
            ProductosFrm M = new ProductosFrm(idRol, idUsuario);
            M.Show();
            this.Hide();
        }

        private void btnIrClientes_Click(object sender, EventArgs e)
        {
            ClientesFrm M = new ClientesFrm(idRol, idUsuario);
            M.Show();
            this.Hide();
        }

        private void btnIrUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosFrm M = new UsuariosFrm(idRol, idUsuario);
            M.Show();
            this.Hide();
        }


        private void Permisos()
        {
            if (idRol == 1)
            {
                label1.Text = "Administrador";
            }
            else if (idRol == 2) 
            {
                label1.Text = "Almacen";
                btnIrProductos.Visible = false;
                btnIrClientes.Visible = false;
                btnIrUsuarios.Visible = false;
            }

            else if (idRol == 3)
            {
                label1.Text = "Consultor";
                btnIrClientes.Visible = false;
                btnIrMovimiento.Visible = false;
                btnIrUsuarios.Visible = false;
                btnIrProductos.Visible=false;
            }
        }

        private void CargarReporte()
        {
            var ds = new InventarioDBDataSet1();
            var ta = new InventarioDBDataSet1TableAdapters.SP_Grafico_MovimientosTableAdapter();

            ta.Fill(ds.SP_Grafico_Movimientos);

            ReportDataSource rds = new ReportDataSource(
                "DataSetGrafico",
                (DataTable)ds.SP_Grafico_Movimientos
            );

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void InicioFrm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            Permisos();
            this.reportViewer1.RefreshReport();
            CargarReporte();
            
        }
    }
}
