using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Negocio
{
    public class DetalleMovimientoBL
    {

        private DetalleMovimientoDAL dal = new DetalleMovimientoDAL();

        public void InsertarDetalle(int idMovimiento, int idProducto, int cantidad)
        {
            DetalleMovimientos d = new DetalleMovimientos
            {
                Id_Movimiento = idMovimiento,
                Id_Producto = idProducto,
                Cantidad = cantidad
            };

            dal.Insertar(d);
        }
    }
}
