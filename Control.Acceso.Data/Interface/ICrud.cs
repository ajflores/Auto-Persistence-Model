using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control.Acceso.Data.Interface
{
    public interface ICrud<T>
    {
        Boolean Insertar(T entidad);
        Boolean Modificar(T entidad);
        Boolean Eliminar(T entidad);
        T RetornarById(int id);
        IList<T> FetchAll();
    }
}
