using Control.Acceso.Entity.Entities;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control.Acceso.Data.Dao
{
    public class UsuarioDao
    {
        public static Usuario FetchUsuarioByClave(ISession session, String clave)
        {
            string q = "select {u.*} from Usuario as u where Clave ='A5529F'";
            var result = session.CreateSQLQuery(q)
                .AddEntity("u", typeof(Usuario))
                .SetMaxResults(1).UniqueResult<Usuario>();
            return result;

            //var sql ="select u.* from Usuario as u where Clave ='A5529F'";
            //var query = session.CreateSQLQuery(sql);
            //var result = query.UniqueResult();

            return null;
        }
    }
}
