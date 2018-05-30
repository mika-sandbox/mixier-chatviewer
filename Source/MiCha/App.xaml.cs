﻿using System.Windows;

namespace MiCha
{
    /// <summary>
    ///     App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var bootstrap = new Bootstrapper();
            bootstrap.Run();
        }
    }
}