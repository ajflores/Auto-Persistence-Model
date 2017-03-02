using Control.Acceso.Data.Factory;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control.Acceso.Data.Interface
{
    public class Crud<T> : ICrud<T> where T : class
    {
        public Boolean Insertar(T entidad)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidad);
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {

                        if (!transaction.WasCommitted)
                            transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public Boolean Modificar(T entidad)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidad);
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {

                        if (!transaction.WasCommitted)
                            transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public Boolean Eliminar(T entidad)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidad);
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {

                        if (!transaction.WasCommitted)
                            transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public T RetornarById(int id)
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
                return session.Get<T>(id);
        }

        public IList<T> FetchAll()
        {
            using (ISession session = FluentySessionFactory.AbrirSession())
                return (from e in session.Query<T>() select e).ToList();
        }
    }
}
