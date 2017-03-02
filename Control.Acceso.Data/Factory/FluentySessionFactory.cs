using Control.Acceso.Entity.Entities;
using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control.Acceso.Data.Factory
{
    public class FluentySessionFactory
    {
        private static ISessionFactory session;
        public static ISessionFactory CrearSession()
        {
            if (session != null)
                return session;
            else
            {
                AutoPersistenceModel model = CreateMappings();
                session = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(c => c
                        .Server("GOLLA")
                        .Database("control_activo")
                        .Username("aj")
                        .Password("Passw0rd")))
                    .Mappings(m => m
                        .AutoMappings.Add(model))
                    //.ExposeConfiguration(BuildSchema)
                    .BuildSessionFactory();
                return session;
            }
        }
        private static AutoPersistenceModel CreateMappings()
        {            
            var autoMap =AutoMap
                .Assembly(System.Reflection.Assembly.GetCallingAssembly())
                .Where(t => t.Namespace == "Control.Acceso.Entity");
            return autoMap;
        }
        private static void BuildSchema(Configuration config)
        {
            //MessageBox.Show("Atencion esto podria destruir todos los datos existentes en la Base de datos");
            new SchemaUpdate(config).Execute(true, true);
        }
        public static ISession AbrirSession()
        {
            return CrearSession().OpenSession();
        }
    }
}
