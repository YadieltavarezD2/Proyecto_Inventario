using Capa.Entidades;
using Capa.Negocio;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class MovimientoFrm : Form
    {
        //listas y variables y todo lo global

        List<DetalleMovimientos> movimientotemp = new List<DetalleMovimientos>();

        private int filaSeleccionada = -1;

        int idRol;
        int idUsuario;

        public MovimientoFrm(int rol, int usuario)
        {
            InitializeComponent();
            ListarMovimientos();
            idRol = rol;
            idUsuario = usuario;
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


        private void MovimientoFrm_Load(object sender, EventArgs e)
        {

            Permisos();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnCheck.BackgroundImageLayout = ImageLayout.Stretch;
            btnX.BackgroundImageLayout = ImageLayout.Stretch;


            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");


            //dgv

            CargarDetalle();
       
        }

        //Barra de navegacion

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

        //metodos

        private void ListarMovimientos()
        {
            TipoMovimientoBL bl = new TipoMovimientoBL();

            cmbMovimiento.DataSource = bl.Listar();
            cmbMovimiento.DisplayMember = "Nombre";
            cmbMovimiento.ValueMember = "Id_Tipo_Movimiento";
            cmbMovimiento.SelectedIndex = -1;
        }

        private void ListarClientes()
        {
            ClientesBL bl = new ClientesBL();
            cmbClienteProveedor.DataSource = bl.Listar();
            cmbClienteProveedor.DisplayMember = "Nombre";
            cmbClienteProveedor.ValueMember = "Id_Cliente";
            cmbClienteProveedor.SelectedIndex = -1;
        }

        private void ListarProveedores()
        {
            ProveedoresBL bl = new ProveedoresBL();
            cmbClienteProveedor.DataSource= bl.Listar();
            cmbClienteProveedor.DisplayMember = "Nombre";
            cmbClienteProveedor.ValueMember = "Id_Proveedor";
            cmbClienteProveedor.SelectedIndex = -1;
        }

        private void ListarProductos()
        {
            ProductosBL bl = new ProductosBL();
            cmbProductos.DataSource = bl.Listar();
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "Id_Producto";
            cmbProductos.SelectedIndex = -1;
        }

        private void ListarProductosP(int idProveedor)
        {
            ProductosBL bl = new ProductosBL();
            cmbProductos.DataSource = bl.ListarPP(idProveedor);
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "Id_Producto";
            cmbProductos.SelectedIndex = -1;
        }

        private int CrearMovimiento()
        {
            TiposMovimiento tm = (TiposMovimiento)cmbMovimiento.SelectedItem;

            Movimientos mv = new Movimientos();
            mv.Id_Tipo_Movimiento = tm.Id_Tipo_Movimiento;
            mv.Id_Usuario = idUsuario;

            if (mv.Id_Tipo_Movimiento == 1) // Entrada
            {
                mv.Id_Proveedor = Convert.ToInt32(cmbClienteProveedor.SelectedValue);
                mv.Id_Cliente = null;
            }
            else // Salida
            {
                mv.Id_Cliente = Convert.ToInt32(cmbClienteProveedor.SelectedValue);
                mv.Id_Proveedor = null;
            }

            // 🔥 INSERTAR Y OBTENER ID
            MovimientosBL movBL = new MovimientosBL();
            int idMovimiento = movBL.InsertarMovimiento(mv);

            // 🔥 DETALLE + STOCK
            DetalleMovimientoBL detBL = new DetalleMovimientoBL();
            ProductosBL prodBL = new ProductosBL();

            foreach (var item in movimientotemp)
            {
                detBL.InsertarDetalle(idMovimiento, item.Id_Producto, item.Cantidad);
                prodBL.ActualizarStock(item.Id_Producto, item.Cantidad, mv.Id_Tipo_Movimiento);
            }

            return idMovimiento; // 🔥 CLAVE
        }

        private void Limpiar()
        {
            cmbProductos.SelectedIndex = -1;
            cmbMovimiento.SelectedIndex = -1;
            cmbClienteProveedor.SelectedIndex = -1;
            txtCantidad.Text = "";
            movimientotemp.Clear();
            CargarDetalle();
        }

        private void CargarDetalle()
        {
            // Limpia primero
            dgvMovimiento.DataSource = null;

            if (movimientotemp.Count == 0)
            {
                dgvMovimiento.Rows.Clear();
                return; // No hay nada que mostrar
            }

            // Solo si hay elementos asignamos la lista
            dgvMovimiento.DataSource = movimientotemp;

            // Configuramos columnas y estilos
            dgvMovimiento.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMovimiento.Columns["Id_Detalle"].Visible = false;
            dgvMovimiento.Columns["Id_Movimiento"].Visible = false;
            dgvMovimiento.Columns["Id_Producto"].Visible = false;
            dgvMovimiento.Columns["Producto"].HeaderText = "Producto";
            dgvMovimiento.Columns["Cantidad"].HeaderText = "Cantidad";
            dgvMovimiento.Columns["Categoria"].HeaderText = "Categoria";
            dgvMovimiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            if (cmbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto antes de continuar");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Ingrese un valor válido para la cantidad");
                return;
            }

            if (cmbMovimiento.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de movimiento.");
                return;
            }

            var prod = (Productos)cmbProductos.SelectedItem;
            var mov = (TiposMovimiento)cmbMovimiento.SelectedItem;
            int idmov = mov.Id_Tipo_Movimiento;

            // EDITAR 
            if (filaSeleccionada != -1)
            {
                // Validar stock si es salida
                if (idmov == 2 && cantidad > prod.Stock)
                {
                    MessageBox.Show("No hay suficiente stock disponible.");
                    return;
                }

                movimientotemp[filaSeleccionada].Id_Producto = prod.Id_Producto;
                movimientotemp[filaSeleccionada].Producto = prod.Nombre;
                movimientotemp[filaSeleccionada].Cantidad = cantidad;
            }
            else
            {
                // Buscar si ya existe el producto
                var existente = movimientotemp
                    .FirstOrDefault(x => x.Id_Producto == prod.Id_Producto);

                if (existente != null)
                {
                    // Validar stock si es salida
                    if (idmov == 2)
                    {
                        int total = existente.Cantidad + cantidad;

                        if (total > prod.Stock)
                        {
                            MessageBox.Show("No hay suficiente stock disponible.");
                            return;
                        }
                    }

                    //SUMAR porque es nuevo pero repetido
                    existente.Cantidad += cantidad;
                }
                else
                {
                    // Validar stock si es salida
                    if (idmov == 2 && cantidad > prod.Stock)
                    {
                        MessageBox.Show("No hay suficiente stock disponible.");
                        return;
                    }

                    // Nuevo producto
                    DetalleMovimientos item = new DetalleMovimientos
                    {
                        Id_Producto = prod.Id_Producto,
                        Producto = prod.Nombre,
                        Categoria = prod.Categoria,
                        Cantidad = cantidad
                    };

                    movimientotemp.Add(item);
                }
            }

            // Refrescar DataGridView
            CargarDetalle();

            // Limpiar controles
            cmbProductos.SelectedIndex = -1;
            txtCantidad.Text = "";
            filaSeleccionada = -1;


            //validacion del stock *

            //agregacion y resta del stock *

            //arreglar el boton cancelar , que elimine del dgv la lista*

            //hacer el boton guardar

           btnGuardar.Enabled = true;
        }

        private void cmbMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = cmbMovimiento.Text;

            if (n == "Entrada")
            {
               lblClienteProveedor.Visible = true;
                cmbClienteProveedor.Visible = true;
                lblClienteProveedor.Text = "Proveedor:";
                ListarProveedores();
               
            }
            else if (n == "Salida") 
            {
                lblClienteProveedor.Visible = true;
                cmbClienteProveedor.Visible = true;
                lblClienteProveedor.Text = "Cliente:";
                ListarClientes();
            }
            else
            {
                lblClienteProveedor.Visible = false;
                cmbClienteProveedor.Visible = false;
            }

        }



       

        private void cmbClienteProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Habilitar o deshabilitar controles según si hay selección
            if (cmbClienteProveedor.SelectedIndex != -1)
            {
                cmbProductos.Enabled = true;
                txtCantidad.Enabled = true;
                btnX.Enabled = true;
                btnCheck.Enabled = true;
            }
            else
            {
                cmbProductos.Enabled = false;
                txtCantidad.Enabled = false;
                btnX.Enabled = false;
                btnCheck.Enabled = false;
                cmbProductos.SelectedIndex = -1;
                return; // Salimos, no hay nada seleccionado
            }

            // Validar que cmbMovimiento tenga selección
            if (cmbMovimiento.SelectedItem == null)
                return; // nada que hacer si no hay movimiento seleccionado

            var mov = (TiposMovimiento)cmbMovimiento.SelectedItem;
            int idmov = mov.Id_Tipo_Movimiento;

            if (idmov == 1)
            {
                if (cmbClienteProveedor.SelectedIndex == -1)
                    return;

                var prov = (Proveedores)cmbClienteProveedor.SelectedItem;
                var idProveedor = prov.Id_Proveedor;
                ListarProductosP(idProveedor);
            }
            else if (idmov == 2)
            {
                ListarProductos();
            }

        }

        private void dgvMovimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validación para no clicar encabezados o filas vacías
            if (e.RowIndex < 0 || dgvMovimiento.Rows.Count == 0) return;

            DataGridViewRow fila = dgvMovimiento.Rows[e.RowIndex];

            // Obtener valores
            string productoNombre = fila.Cells["Producto"].Value?.ToString() ?? "";
            int cantidad = fila.Cells["Cantidad"].Value != null ? Convert.ToInt32(fila.Cells["Cantidad"].Value) : 0;

            // Buscar el objeto en la lista para obtener Id_Producto
            int idProducto = fila.Cells["Id_Producto"] != null ? Convert.ToInt32(fila.Cells["Id_Producto"].Value) : -1;

            // Seleccionar el producto en el ComboBox
            for (int i = 0; i < cmbProductos.Items.Count; i++)
            {
                var prod = (Productos)cmbProductos.Items[i];
                if (prod.Id_Producto == idProducto)
                {
                    cmbProductos.SelectedIndex = i;
                    break;
                }
            }

            // Poner la cantidad en el TextBox
            txtCantidad.Text = cantidad.ToString();

            // Guardamos el índice de la fila seleccionada en un variable global para modificar o eliminar después
            filaSeleccionada = e.RowIndex;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada < 0)
            {
                MessageBox.Show("Seleccione un registro del DataGridView para eliminar.");
                return;
            }

            // Eliminar de la lista
            movimientotemp.RemoveAt(filaSeleccionada);

            // Refrescar DataGridView
            CargarDetalle();

            // Limpiar controles
            cmbProductos.SelectedIndex = -1;
            txtCantidad.Text="";
            filaSeleccionada = -1;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnGuardar.Enabled = false; 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idMovimiento = CrearMovimiento();

            InformeFrm frm = new InformeFrm(idMovimiento);
            frm.ShowDialog();

            Limpiar();
        }

        private void altoGroupBox2_Click(object sender, EventArgs e)
        {

        }
    }
    }
