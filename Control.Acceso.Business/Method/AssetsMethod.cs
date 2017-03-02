using Control.Acceso.Business.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Control.Acceso.Entity.Entities;

namespace Control.Acceso.Business.Method
{
    public class AssetsMethod: IAssetsMethod
    {
        private readonly IUsuarioRepository usuarioRepository;
        public AssetsMethod(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }

        public Usuario FetchUsuarioByClave(string clave)
        {
            return usuarioRepository.FetchUsuarioByClave(clave);
        }
        public bool Insert(Usuario usuario)
        {
            return usuarioRepository.Insertar(usuario);
        }
    }
}
