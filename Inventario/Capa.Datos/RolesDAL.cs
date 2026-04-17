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
   
        public class RolesDAL
        {
            public List<Roles> Listar()
            {
                List<Roles> lista = new List<Roles>();

                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_Read_Roles", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new Roles
                        {
                            Id_Rol = (int)dr["Id_Rol"],
                            Nombre_Rol = dr["Nombre_Rol"].ToString()
                        });
                    }
                }

                return lista;
            }
        }
    }

