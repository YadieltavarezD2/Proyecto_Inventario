using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Clientes
    {
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula_RNC { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
    }
}
