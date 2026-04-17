using Capa.Datos;
using Capa.Entidades;
using System.Collections.Generic;

namespace Capa.Negocio
{
    public class UsuariosBL
    {
        private UsuariosDAL dal = new UsuariosDAL();

        public List<Usuarios> Listar()
        {
            return dal.Listar();
        }

        public void Agregar(Usuarios u)
        {
            if (u.Id_Usuario == 0)
                dal.Insertar(u);
            else
                dal.Actualizar(u);
        }

        public void Eliminar(int idUsuario)
        {
            dal.Eliminar(idUsuario);
        }
        public Usuarios Login(string username, string password)
        {
            return dal.Login(username, password);
        }

    }
}