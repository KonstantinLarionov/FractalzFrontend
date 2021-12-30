using FractalzWPF.Infrastructure.Application;
using FractalzWPF.Infrastructure.Application.Handlers;
using FractalzWPF.Infrastructure.Connector;
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

            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = SC.provider.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
