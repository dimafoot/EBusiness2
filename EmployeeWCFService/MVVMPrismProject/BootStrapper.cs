using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Unity;
using MVVMPrismProject.Views;
using Prism.Unity;

namespace MVVMPrismProject
{
    public class BootStrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType(typeof(object), typeof(ViewA), "ViewA");
            Container.RegisterType(typeof(object), typeof(ViewB), "ViewB");

            //Container.RegisterTypeForNavigation<ViewA>("ViewA");
            //Container.RegisterTypeForNavigation<ViewB>("ViewB");

        }
    }
}
