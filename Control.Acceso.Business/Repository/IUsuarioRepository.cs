using Control.Acceso.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control.Acceso.Business.Repository
{
    public interface IUsuarioRepository
    {
        Usuario FetchUsuarioByClave(String clave);
        Boolean Insertar(Usuario usuario);
        Boolean Modificar(Usuario usuario);
        Boolean Eliminar(Usuario usuario);
    }
}
