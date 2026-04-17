using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Datos;
using Capa.Entidades;

namespace Capa.Negocio
{
    public class ProductosBL
    {
        ProductosDAL dal = new ProductosDAL();

        public List<Productos> Listar()
        {
            return dal.Listar();
        }
    

            public List<Productos> ListarPP(int idProveedor)
            {
                return dal.ListarPP(idProveedor);
            }

    
        public void ActualizarStock(int idProducto, int cantidad, int tipo)
        { 
            dal.ActualizarStock(idProducto, cantidad, tipo);
        }
        public void Insertar(Productos p)
        {
            dal.Insertar(p);
        }

        public void Actualizar(Productos p)
        {
            dal.Actualizar(p);
        }

        public void Eliminar(int id)
        {
            dal.Eliminar(id);
        }
    }
}
