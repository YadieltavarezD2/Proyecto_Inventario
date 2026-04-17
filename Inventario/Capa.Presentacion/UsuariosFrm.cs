using Capa.Datos;
using Capa.Entidades;
using Capa.Negocio;
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
    public partial class UsuariosFrm : Form
    {

        int idRol , idUsuario ;
        public UsuariosFrm(int rol, int usuario)
        {
            InitializeComponent();
            idRol = rol;
            idUsuario = usuario;
        }

        UsuariosBL bl = new UsuariosBL();
        int idSeleccionado = 0;

        // barra de nav

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
        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = bl.Listar();

            dgvUsuarios.Columns["Id_Usuario"].Visible = false;
            dgvUsuarios.Columns["Id_Rol"].Visible = false;
            dgvUsuarios.Columns["Estado"].Visible = false;
            dgvUsuarios.Columns["Password"].Visible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
        private void CargarRoles()
        {
            RolesBL bl = new RolesBL();

            cmbRol.DataSource = bl.Listar();
            cmbRol.DisplayMember = "Nombre_Rol"; 
            cmbRol.ValueMember = "Id_Rol";

            cmbRol.SelectedIndex = -1;
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtUsername.Clear();
            txtContraseña.Clear();

            cmbRol.SelectedIndex = -1;

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
        private void UsuariosFrm_Load(object sender, EventArgs e)
        {
            Permisos();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            CargarUsuarios();
            CargarRoles();
        }

        private void btnCrearUser_Click(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(txtNombre.Text))
    {
        MessageBox.Show("Ingrese el nombre");
        return;
    }

    if (string.IsNullOrWhiteSpace(txtUsername.Text))
    {
        MessageBox.Show("Ingrese el username");
        return;
    }

    if (idSeleccionado == 0 && string.IsNullOrWhiteSpace(txtContraseña.Text))
    {
        MessageBox.Show("Ingrese la contraseña");
        return;
    }

    if (cmbRol.SelectedIndex == -1)
    {
        MessageBox.Show("Seleccione un rol");
        return;
    }

    Usuarios u = new Usuarios()
    {
        Id_Usuario = idSeleccionado,
        Nombre = txtNombre.Text,
        Username = txtUsername.Text,
        Password = txtContraseña.Text,
        Id_Rol = (int)cmbRol.SelectedValue
    };

    bl.Agregar(u);

    MessageBox.Show(idSeleccionado == 0 ? "Usuario agregado" : "Usuario actualizado");

    CargarUsuarios();
    Limpiar();

        }

        private void buttonRound2_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            bl.Eliminar(idSeleccionado);

            CargarUsuarios();
            Limpiar();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];

                idSeleccionado = (int)fila.Cells["Id_Usuario"].Value;

                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtUsername.Text = fila.Cells["Username"].Value.ToString();

                cmbRol.Text = fila.Cells["Nombre_Rol"].Value.ToString();

                txtContraseña.Text = "";
            }
            }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
    }
