using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Productos
    {
        public int Id_Producto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int Id_Categoria { get; set; }

        public string Categoria { get; set; }
        public int Id_Proveedor { get; set; }

        public string Proveedor { get; set; }
        public int Creado_Por { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public bool Estado { get; set; }
    }

}
