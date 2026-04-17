using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa.Negocio
{
    public class TipoMovimientoBL
    {
        TiposMovimientosDAL dal = new TiposMovimientosDAL();

        public List<TiposMovimiento> Listar()
        {
            return dal.Listar();
        }
    }

}
