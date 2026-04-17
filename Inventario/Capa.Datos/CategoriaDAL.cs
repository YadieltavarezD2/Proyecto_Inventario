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
    public class CategoriaDAL
    {
        public List<Categorias> Listar()
        {
            List<Categorias> lista = new List<Categorias>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Read_Categorias", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Categorias
                    {
                        Id_Categoria = (int)dr["Id_Categoria"],
                        Nombre = dr["Nombre"].ToString(),
                        Estado = (bool)dr["Estado"]
                    });
                }
            }

            return lista;
        }

        public void Insertar(Categorias c)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Create_Categorias", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Actualizar(Categorias c)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Update_Categorias", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Categoria", c.Id_Categoria);
                cmd.Parameters.AddWithValue("@Nombre", c.Nombre);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Eliminar(int idCategoria)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Delete_Categorias", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Categoria", idCategoria);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

        }

    }
}
