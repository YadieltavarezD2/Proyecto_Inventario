using Capa.Entidades;
using CapaNegocio;
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
    public partial class ProveedoresFrm : Form
    {
        ProveedoresBL bl = new ProveedoresBL();
        int idSeleccionado = 0;

        int idRol, idUsuario;
        public ProveedoresFrm(int rol,int usuarios)
        {
            InitializeComponent();
            idUsuario = usuarios;
            idRol = rol;
            
        }

        private void btnIrLogin_Click(object sender, EventArgs e)
        {
            LoginFrm i = new LoginFrm();
            i.Show();
            this.Hide();
        }
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

        private void CargarProveedores()
        {
            dgvProveedores.DataSource = bl.Listar();

            dgvProveedores.Columns["Id_Proveedor"].Visible = false;
            dgvProveedores.Columns["Estado"].Visible = false;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Limpiar()
        {
            txtNombreCliente.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            idSeleccionado = 0;
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
                btnIrProductos.Visible = false;
            }
        }
        private void ProveedoresFrm_Load(object sender, EventArgs e)
        {
            Permisos();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            CargarProveedores();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                MessageBox.Show("Ingrese el nombre del proveedor");
                return;
            }

            Proveedores p = new Proveedores()
            {
                Id_Proveedor = idSeleccionado,
                Nombre = txtNombreCliente.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text
            };

            bl.Agregar(p);

            MessageBox.Show(idSeleccionado == 0 ? "Proveedor agregado" : "Proveedor actualizado");

            CargarProveedores();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            bl.Eliminar(idSeleccionado);

            CargarProveedores();
            Limpiar();
        }

        private void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                idSeleccionado = (int)fila.Cells["Id_Proveedor"].Value;

                txtNombreCliente.Text = fila.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
