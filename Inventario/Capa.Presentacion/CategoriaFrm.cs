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
    public partial class CategoriaFrm : Form
    {
        //global 
        CategoriasBL bl = new CategoriasBL();
        int idSeleccionado = 0;

        int idRol, idUsuario;

        public CategoriaFrm(int rol,int usuario)
        {
            InitializeComponent();
            idRol = rol;
            idUsuario= usuario;
            
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



        //metodo
        private void CargarCategorias()
        {
            dgvCategoria.DataSource = bl.Listar();

            dgvCategoria.Columns["Id_Categoria"].Visible = false;
            dgvCategoria.Columns["Estado"].Visible = false;
        }
        private void Limpiar()
        {
            txtCategoria.Clear();
            idSeleccionado = 0;
        }

        //codigo

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
        private void CategoriaFrm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            CargarCategorias();
            Permisos();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Ingrese el nombre de la categoría");
                return;
            }

            Categorias c = new Categorias()
            {
                Id_Categoria = idSeleccionado, 
                Nombre = txtCategoria.Text
            };

            bl.Agregar(c);

            MessageBox.Show(idSeleccionado == 0 ? "Categoría agregada" : "Categoría actualizada");

            CargarCategorias();
            Limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una categoría");
                return;
            }

            bl.Eliminar(idSeleccionado);

            CargarCategorias();
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void altoGroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategoria.Rows[e.RowIndex];

                idSeleccionado = (int)fila.Cells["Id_Categoria"].Value;

                txtCategoria.Text = fila.Cells["Nombre"].Value.ToString();
            }
        }
    }
}
