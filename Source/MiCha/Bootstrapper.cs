using System.Windows;

using MiCha.Services;
using MiCha.Views;

using Prism.Unity;

using Unity;
using Unity.Lifetime;

namespace MiCha
{
#pragma warning disable CS0618 // 型またはメンバーが古い形式です

    internal class Bootstrapper : UnityBootstrapper
#pragma warning restore CS0618 // 型またはメンバーが古い形式です
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            Container.RegisterType<IStatusTextService, StatusTextService>(new ContainerControlledLifetimeManager());
        }

        protected override void InitializeShell()
        {
            // ReSharper disable once PossibleNullReferenceException
            Application.Current.MainWindow.Show();
        }
    }
}