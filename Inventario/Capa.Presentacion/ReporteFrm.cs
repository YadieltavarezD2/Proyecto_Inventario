using Capa.Entidades;
using Capa.Negocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class ReporteFrm : Form
    {
        int idRol;
        int idUsuario;
        public ReporteFrm(int rol, int usuario)
{
    InitializeComponent();
    idRol = rol;
    idUsuario = usuario;
}

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

        private void CargarM()
        {
            MovimientosBL m = new MovimientosBL();

            comboBox1.DataSource = m.Listar();
            comboBox1.DisplayMember = "Id_Movimiento";
            comboBox1.ValueMember = "Id_Movimiento"; // 🔥 ESTA LÍNEA ES CLAVE
            comboBox1.SelectedIndex = -1;
        }

        private void Permisos()
        {
            if (idRol == 1)
            {
                label2.Text = "Administrador";
            }
            else if (idRol == 2)
            {
                label2.Text = "Almacen";
                button4.Visible = false;
                btnIrClientes.Visible = false;
                button3.Visible = false;
            }

            else if (idRol == 3)
            {
                label2.Text = "Consultor";
                btnIrClientes.Visible = false;
                button6.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
        }
        private void ReporteFrm_Load(object sender, EventArgs e)
        {
            Permisos();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            this.reportViewer1.RefreshReport();
             CargarM();
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un movimiento");
                return;
            }

            int id = Convert.ToInt32(comboBox1.SelectedValue);

            InformeFrm frm = new InformeFrm(id); // 🔥 AQUÍ ESTÁ LA CLAVE
            frm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (comboBox1.SelectedValue == null)
                return;

            // 🔥 evita cuando todavía es objeto
            if (!(comboBox1.SelectedValue is int))
                return;

            int idMovimiento = (int)comboBox1.SelectedValue;
            if (comboBox1.SelectedIndex == -1)
                return;

           
            var ds = new InventarioDBDataSet();

            var ta = new InventarioDBDataSetTableAdapters
                .SP_Reporte_Movimiento_Por_IdTableAdapter(); // 🔥 correcto

            ds.EnforceConstraints = false;

            ta.Fill(ds.SP_Reporte_Movimiento_Por_Id, idMovimiento); // 🔥 correcto

            ReportDataSource rds = new ReportDataSource(
                "DataSetMovimiento", // 🔥 debe coincidir con el RDLC
                (DataTable)ds.SP_Reporte_Movimiento_Por_Id
            );

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }
    }
    }
