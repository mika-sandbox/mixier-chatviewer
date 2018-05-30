using System.Windows;

using Microsoft.Practices.Unity;

using MiCha.Views;

using Prism.Unity;

namespace MiCha
{
    internal class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window) Shell;
            // ReSharper disable once PossibleNullReferenceException
            Application.Current.MainWindow.Show();
        }
    }
}