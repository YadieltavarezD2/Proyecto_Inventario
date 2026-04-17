using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocio
{
    public class MovimientosBL
    {
        MovimientosDAL dal = new MovimientosDAL();
        public List<Movimientos> Listar()
        { 
                return dal.Listar();
        }

        public int InsertarMovimiento(Movimientos movimientos)
        {
           return dal.Insertar(movimientos);
        }
    }
}
