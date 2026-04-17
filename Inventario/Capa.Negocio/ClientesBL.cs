using Capa.Datos;
using Capa.Entidades;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class ClientesBL
    {
        private ClientesDAL dal = new ClientesDAL();

        public List<Clientes> Listar()
        {
            return dal.Listar();
        }

        public void Agregar(Clientes c)
        {
            if (c.Id_Cliente == 0)
                dal.Insertar(c);
            else
                dal.Actualizar(c);
        }

        public void Eliminar(int idCliente)
        {
            dal.Eliminar(idCliente);
        }


    }
}
