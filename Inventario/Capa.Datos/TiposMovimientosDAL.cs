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
    public class TiposMovimientosDAL
    {
            public List<TiposMovimiento> Listar()
            {
                List<TiposMovimiento> lista = new List<TiposMovimiento>();

                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("SP_Read_Tipos_Movimiento", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        lista.Add(new TiposMovimiento
                        {
                            Id_Tipo_Movimiento = (int)dr["Id_Tipo_Movimiento"],
                            Nombre = dr["Nombre"].ToString()
                        });
                    }
                }

                return lista;
            }
        }

    }

