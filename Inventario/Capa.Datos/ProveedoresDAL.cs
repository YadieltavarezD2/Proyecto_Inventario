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
    public class ProveedoresDAL
    {
        public List<Proveedores> Listar()
        {
            List<Proveedores> lista = new List<Proveedores>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Read_Proveedores", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Proveedores
                    {
                        Id_Proveedor = (int)dr["Id_Proveedor"],
                        Nombre = dr["Nombre"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Estado = (bool)dr["Estado"]
                    });
                }
            }

            return lista;
        }

        public void Insertar(Proveedores p)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Create_Proveedores", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", p.Direccion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

  
        public void Actualizar(Proveedores p)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Update_Proveedores", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Proveedor", p.Id_Proveedor);
                cmd.Parameters.AddWithValue("@Nombre", p.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", p.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", p.Direccion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idProveedor)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Delete_Proveedores", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Proveedor", idProveedor);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
