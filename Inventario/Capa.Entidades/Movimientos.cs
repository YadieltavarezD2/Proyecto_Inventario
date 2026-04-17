using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Movimientos
    {
        public int Id_Movimiento { get; set; }
        public int Id_Tipo_Movimiento { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Usuario { get; set; }
        public int? Id_Cliente { get; set; }
        public int? Id_Proveedor { get; set; }

        //campos q se muestran
        public string Tipo_Movimiento { get; set; }
        public string Usuario { get; set; }
        public string Cliente { get; set; }
        public string Proveedor { get; set; }
    }
}
