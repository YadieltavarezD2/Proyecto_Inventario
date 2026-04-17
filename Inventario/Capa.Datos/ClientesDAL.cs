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
    public class ClientesDAL
    {
        public List<Clientes> Listar()
        {
            List<Clientes> lista = new List<Clientes>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Read_Clientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Clientes
                    {
                        Id_Cliente = (int)dr["Id_Cliente"],
                        Nombre = dr["Nombre"].ToString(),
                        Cedula_RNC = dr["Cedula_RNC"].ToString(),
                        Direccion = dr["Direccion"].ToString(),
                        Telefono = dr["Telefono"].ToString(),
                        Email = dr["Email"].ToString(),
                        Estado = (bool)dr["Estado"]
                    });
                }
            }
            return lista;
        }

        public void Insertar(Clientes cliente)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Create_Clientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Cedula_RNC", cliente.Cedula_RNC);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Clientes cliente)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Update_Clientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Cliente", cliente.Id_Cliente);
                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idCliente)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Delete_Clientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Cliente", idCliente);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
