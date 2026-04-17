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
    public class MovimientosDAL
    {
        public List<Movimientos> Listar()
        {
            List<Movimientos> lista = new List<Movimientos>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Read_Movimientos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Movimientos
                    {
                        Id_Movimiento = (int)dr["Id_Movimiento"],
                        Id_Tipo_Movimiento = (int)dr["Id_Tipo_Movimiento"],
                        Tipo_Movimiento = dr["Tipo_Movimiento"].ToString(),

                        Fecha = (DateTime)dr["Fecha"],

                        Id_Usuario = (int)dr["Id_Usuario"],
                        Usuario = dr["Usuario"].ToString(),

                        Id_Cliente = dr["Id_Cliente"] == DBNull.Value ? null : (int?)dr["Id_Cliente"],
                        Cliente = dr["Cliente"]?.ToString(),

                        Id_Proveedor = dr["Id_Proveedor"] == DBNull.Value ? null : (int?)dr["Id_Proveedor"],
                        Proveedor = dr["Proveedor"]?.ToString()
                    });
                }
            }
            return lista;
        }

        public int Insertar(Movimientos m)
        {
            int idGenerado = 0;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Create_Movimientos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Tipo_Movimiento", m.Id_Tipo_Movimiento);
                cmd.Parameters.AddWithValue("@Id_Usuario", m.Id_Usuario);

                cmd.Parameters.AddWithValue("@Id_Cliente",
                    m.Id_Cliente.HasValue ? (object)m.Id_Cliente.Value : DBNull.Value);

                cmd.Parameters.AddWithValue("@Id_Proveedor",
                    m.Id_Proveedor.HasValue ? (object)m.Id_Proveedor.Value : DBNull.Value);

                cn.Open();

                idGenerado = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return idGenerado;
        }




    }
}
