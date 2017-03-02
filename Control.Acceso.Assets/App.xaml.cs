using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace Control.Acceso.Assets
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            using (var container = new WindsorContainer().Install(FromAssembly.This()))
            {
                var main = container.Resolve<Ventana.Inicio>();
                this.Run(main);
            }
        }
    }
}
