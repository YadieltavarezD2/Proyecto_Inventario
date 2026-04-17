using Capa.Entidades;
using Capa.Datos;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CategoriasBL
    {
        private CategoriaDAL dal = new CategoriaDAL();

        public List<Categorias> Listar()
        {
            return dal.Listar();
        }

        public void Agregar(Categorias c)
        {
            if (c.Id_Categoria == 0)
                dal.Insertar(c);
            else
                dal.Actualizar(c);
        }

        public void Eliminar(int idCategoria)
        {
            dal.Eliminar(idCategoria);
        }
    }
}
