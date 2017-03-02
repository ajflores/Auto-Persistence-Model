using Control.Acceso.Business.Repository;
using Control.Acceso.Data.Dao;
using Control.Acceso.Data.Factory;
using Control.Acceso.Data.Interface;
using Control.Acceso.Entity.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control.Acceso.Data.Repository
{
    public class UsuarioRepository : Crud<Usuario>, IUsuarioRepository
    {
        public Usuario FetchUsuarioByClave(string clave)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                return Dao.UsuarioDao.FetchUsuarioByClave(session,clave);
            }
        }
    }
}
