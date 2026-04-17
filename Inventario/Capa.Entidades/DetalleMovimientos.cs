using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class DetalleMovimientos
    {
        public int Id_Detalle { get; set; }
        public int Id_Movimiento { get; set; }
        public int Id_Producto { get; set; }
        public string Producto { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
    }
}
