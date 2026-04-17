using Capa.Datos;
using Capa.Entidades;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class ProveedoresBL
    {
        private ProveedoresDAL dal = new ProveedoresDAL();

        public List<Proveedores> Listar()
        {
            return dal.Listar();
        }

        public void Agregar(Proveedores p)
        {
            if (p.Id_Proveedor == 0)
                dal.Insertar(p);
            else
                dal.Actualizar(p);
        }

        public void Eliminar(int idProveedor)
        {
            dal.Eliminar(idProveedor);
        }
    }
}
