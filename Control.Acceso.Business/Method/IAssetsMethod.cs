using Control.Acceso.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control.Acceso.Business.Method
{
    public interface IAssetsMethod
    {
        Usuario FetchUsuarioByClave(String clave);
    }
}
