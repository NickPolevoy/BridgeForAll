using Microsoft.Practices.Unity;
using Prism.Unity;
using BridgeForAll.Views;
using System.Windows;

namespace BridgeForAll
{
    using Autofac;
    using DeskForGame;
    using Prism.Autofac;
    using Prism.Modularity;

    class Bootstrapper : AutofacBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(DeskForGameModule));
        }

    }
}
