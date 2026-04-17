
using Capa.Entidades;
using Capa.Negocio;
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
    public partial class ProductosFrm : Form
    {
        //global
        ProductosBL bl = new ProductosBL();
        int idSeleccionado = 0;

        int idRol, idUsuario;
        public ProductosFrm(int rol, int usuario)
        {
            InitializeComponent();
            idRol = rol;
            idUsuario = usuario;
        }

        //glo
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
                btnIrProductos.Visible = false;
            }
        }

        private void ProductosFrm_Load(object sender, EventArgs e)
        {
            Permisos();
            CargarProductos();
            CargarCombos();

            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            


        }

        private void btnIrCategoria_Click(object sender, EventArgs e)
        {
            CategoriaFrm M = new CategoriaFrm(idRol,idUsuario);
            M.Show();
            this.Hide();
        }
        //metodos

        private void Limpiar()
        {
            txtNProducto.Clear();
            txtPrecio.Clear();

            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;

            idSeleccionado = 0;
        }
        private void CargarProductos()
        {
            dgvProductos.DataSource = bl.Listar();

            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            // ocultar columnas 
            dgvProductos.Columns["Id_Producto"].Visible = false;
            dgvProductos.Columns["Id_Categoria"].Visible = false;
            dgvProductos.Columns["Id_Proveedor"].Visible = false;
            dgvProductos.Columns["Creado_Por"].Visible = false;
            dgvProductos.Columns["Estado"].Visible = false;
            dgvProductos.Columns["Fecha_Creacion"].Visible = false;

        }

        private void CargarCombos()
        {
           
            cmbCategoria.DataSource = new CategoriasBL().Listar();
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id_Categoria";

            cmbProveedor.DataSource = new ProveedoresBL().Listar();
            cmbProveedor.DisplayMember = "Nombre";
            cmbProveedor.ValueMember = "Id_Proveedor";

            cmbCategoria.SelectedIndex = -1;
            cmbProveedor.SelectedIndex = -1;
        }


      
        
        //el codigo

        private void buttonRound1_Click(object sender, EventArgs e)
        {


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex == -1 || cmbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione categoría y proveedor");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNProducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Precio inválido");
                return;
            }

            // 🔥 SI HAY SELECCIÓN → ACTUALIZA
            if (idSeleccionado != 0)
            {
                Productos p = new Productos()
                {
                    Id_Producto = idSeleccionado,
                    Precio = precio,
                    Stock = 0 // ajusta si luego usas txtStock
                };

                bl.Actualizar(p);

                MessageBox.Show("Producto actualizado");
            }
            else 
            {
                Productos p = new Productos()
                {
                    Nombre = txtNProducto.Text,
                    Precio = precio,
                    Stock = 0,
                    Id_Categoria = (int)cmbCategoria.SelectedValue,
                    Id_Proveedor = (int)cmbProveedor.SelectedValue,
                    Creado_Por = 1
                };

                bl.Insertar(p);

                MessageBox.Show("Producto agregado");
            }

            CargarProductos();
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            bl.Eliminar(idSeleccionado);

            CargarProductos();
            Limpiar();
        }
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

                idSeleccionado = (int)fila.Cells["Id_Producto"].Value;

                txtNProducto.Text = fila.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();

                cmbCategoria.SelectedValue = fila.Cells["Id_Categoria"].Value;
                cmbProveedor.SelectedValue = fila.Cells["Id_Proveedor"].Value;
            }
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
