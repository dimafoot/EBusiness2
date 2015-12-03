using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Unity;
using PrismProjectMVVM2.Views;

namespace PrismProjectMVVM2
{
    public class BootStrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<BaseView>();
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
        }
    }
}
