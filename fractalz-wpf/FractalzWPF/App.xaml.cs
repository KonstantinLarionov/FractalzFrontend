using FractalzWPF.Infrastructure.Application;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using FractalzWPF.Infrastructure.Application.Handlers;
using FractalzWPF.Infrastructure.Connector;
using FractalzWPF.Infrastructure.Vizualizer;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FractalzWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            SC.provider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddInfrastructureConnector();
            services.AddApplication();
            services.AddUserControls();
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = SC.provider.GetService<MainWindow>();
            var navigator = SC.provider.GetService<INavigatorControls>();
            navigator.Windows[WindowType.Registration].Show();
            navigator.Windows[WindowType.Login].Show();
            navigator.Windows[WindowType.TodoCreate].Show();
            mainWindow.Show();
        }
    }
}
