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
    public class DetalleMovimientoDAL
    {
        public List<DetalleMovimientos> Listar()
        {
            List<DetalleMovimientos> lista = new List<DetalleMovimientos>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Read_Detalle_Movimientos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new DetalleMovimientos
                    {
                        Id_Detalle = (int)dr["Id_Detalle"],
                        Id_Movimiento = (int)dr["Id_Movimiento"],
                        Id_Producto = (int)dr["Id_Producto"],
                        Cantidad = (int)dr["Cantidad"]
                    });
                }
            }

            return lista;
        }

        public void Insertar(DetalleMovimientos d)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Create_Detalle_Movimientos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Movimiento", d.Id_Movimiento);
                cmd.Parameters.AddWithValue("@Id_Producto", d.Id_Producto);
                cmd.Parameters.AddWithValue("@Cantidad", d.Cantidad);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //esto va para ususrios en espcifico
        public void Actualizar(DetalleMovimientos d)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Update_Detalle_Movimientos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Detalle", d.Id_Detalle);
                cmd.Parameters.AddWithValue("@Cantidad", d.Cantidad);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        //este solo los admin
        public void Eliminar(int idDetalle)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Delete_Detalle_Movimientos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Detalle", idDetalle);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
