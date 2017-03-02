using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Control.Acceso.Business.Method;
using Control.Acceso.Business.Repository;
using Control.Acceso.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Control.Acceso.Assets
{
    public class Installation: IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly().BasedOn<Window>().WithService.Self().LifestyleTransient());
            container.Register(Component.For<IAssetsMethod>().ImplementedBy<AssetsMethod>().LifestyleTransient());
            container.Register(Component.For<IUsuarioRepository>().ImplementedBy<UsuarioRepository>().LifestyleTransient());
            
        }
    }
}
