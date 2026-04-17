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
    public class UsuariosDAL
    {
        public List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Read_Usuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Usuarios
                    {
                        Id_Usuario = (int)dr["Id_Usuario"],
                        Nombre = dr["Nombre"].ToString(),
                        Username = dr["Username"].ToString(),
                        Nombre_Rol = dr["Nombre_Rol"].ToString()
                    });
                }
            }

            return lista;
        }

        public void Insertar(Usuarios u)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Create_Usuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@Username", u.Username);
                cmd.Parameters.AddWithValue("@Password", u.Password);
                cmd.Parameters.AddWithValue("@Id_Rol", u.Id_Rol);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Actualizar(Usuarios u)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Update_Usuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Usuario", u.Id_Usuario);
                cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
                cmd.Parameters.AddWithValue("@Username", u.Username);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void Eliminar(int idUsuario)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Delete_Usuarios", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Usuario", idUsuario);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Usuarios Login(string username, string password)
        {
            Usuarios user = null;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Login_Usuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    user = new Usuarios()
                    {
                        Id_Usuario = (int)dr["Id_Usuario"],
                        Nombre = dr["Nombre"].ToString(),
                        Username = dr["Username"].ToString(),
                        Id_Rol = (int)dr["Id_Rol"]
                    };
                }
            }

            return user;
        }
    }
}
