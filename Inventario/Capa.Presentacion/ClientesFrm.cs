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
    public partial class ClientesFrm : Form
    {
        ClientesBL bl = new ClientesBL();
        int idSeleccionado = 0;

        int idUsuario, idRol;
        public ClientesFrm(int rol, int usuario)
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

        private void CargarClientes()
        {
            dgvClientes.DataSource = bl.Listar();

            dgvClientes.Columns["Id_Cliente"].Visible = false;
            dgvClientes.Columns["Estado"].Visible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Limpiar()
        {
            txtNombreCliente.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();

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
        private void ClientesFrm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            CargarClientes();
            Permisos();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text))
            {
                MessageBox.Show("Ingrese el nombre");
                return;
            }

            Clientes c = new Clientes()
            {
                Id_Cliente = idSeleccionado, // 🔥 clave
                Nombre = txtNombreCliente.Text,
                Cedula_RNC = txtCedula.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Email = txtEmail.Text
            };

            bl.Agregar(c);

            MessageBox.Show(idSeleccionado == 0 ? "Cliente agregado" : "Cliente actualizado");

            CargarClientes();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            bl.Eliminar(idSeleccionado);

            CargarClientes();
            Limpiar();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                idSeleccionado = (int)fila.Cells["Id_Cliente"].Value;

                txtNombreCliente.Text = fila.Cells["Nombre"].Value.ToString();
                txtCedula.Text = fila.Cells["Cedula_RNC"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = fila.Cells["Direccion"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnIrProveedores_Click(object sender, EventArgs e)
        {
            ProveedoresFrm m = new ProveedoresFrm(idRol,idUsuario);
            m.Show();
            this.Hide();
        }
    }
}
