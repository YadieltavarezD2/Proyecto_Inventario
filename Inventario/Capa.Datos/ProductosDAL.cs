using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class ProductosDAL
    {
        public List<Productos> Listar()
        {
            List<Productos> lista = new List<Productos>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Read_Productos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Productos
                    {
                        Id_Producto = (int)dr["Id_Producto"],
                        Nombre = dr["Nombre"].ToString(),
                        Precio = (decimal)dr["Precio"],
                        Stock = (int)dr["Stock"],

                        Id_Categoria = (int)dr["Id_Categoria"],
                        Categoria = dr["Categoria"].ToString(),

                        Id_Proveedor = (int)dr["Id_Proveedor"],
                        Proveedor = dr["Proveedor"].ToString()
                    });
                }
            }
            return lista;
        }

       
        public void Insertar(Productos p)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Create_Productos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Precio", p.Precio);
                cmd.Parameters.AddWithValue("@Stock", p.Stock);
                cmd.Parameters.AddWithValue("@Id_Categoria", p.Id_Categoria);
                cmd.Parameters.AddWithValue("@Id_Proveedor", p.Id_Proveedor);
                cmd.Parameters.AddWithValue("@Creado_Por", p.Creado_Por);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Productos p)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Update_Productos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Producto", p.Id_Producto);
                cmd.Parameters.AddWithValue("@Precio", p.Precio);
                cmd.Parameters.AddWithValue("@Stock", p.Stock);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void ActualizarStock(int idProducto, int cantidad, int tipo)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Update_Stock", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Producto", idProducto);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@Tipo", tipo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idProducto)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Delete_Productos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Producto", idProducto);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //proc especiales
        public List<Productos> ListarPP(int idProveedor)
        {
            List<Productos> lista = new List<Productos>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Productos_Por_Proveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                
                cmd.Parameters.AddWithValue("@Id_Proveedor", idProveedor);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Productos
                    {
                        Id_Producto = (int)dr["Id_Producto"],
                        Nombre = dr["Nombre"].ToString(),
                        Precio = (decimal)dr["Precio"],
                        Stock = (int)dr["Stock"],

                        Id_Categoria = (int)dr["Id_Categoria"],
                        Categoria = dr["Categoria"].ToString(),

                        Id_Proveedor = (int)dr["Id_Proveedor"],
                        Proveedor = dr["Proveedor"].ToString()
                    });
                }
            }
            return lista;
        }

    }
}
