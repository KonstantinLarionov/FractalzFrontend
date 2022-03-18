using FractalzWPF.Infrastructure.Application;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using FractalzWPF.Infrastructure.Application.Handlers;
using FractalzWPF.Infrastructure.Connector;
using FractalzWPF.Infrastructure.Vizualizer;
using FractalzWPF.Infrastructure.LinkedEvent;

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using FractalzWPF.Application.Domains.Entities.Profile;
using Microsoft.Extensions.Configuration;

namespace FractalzWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public IConfiguration Configuration { get; private set; }
        public App()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
 
            Configuration = builder.Build();
            
            var services = new ServiceCollection();
            ConfigureServices(services);
            
            SC.provider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.Configure<UserData>(Configuration.GetSection("UserData"));
            
            services.AddApplication();
            services.AddInfrastructureConnector();
            services.AddInfrastructureVisualizer();
            services.AddInfrastructureLinkedEvent();
            
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = SC.provider.GetService<MainWindow>();
            var navigator = SC.provider.GetService<INavigatorControls>();
            //
            // navigator.Windows[WindowType.Registration].Show();
            // navigator.Windows[WindowType.Login].Show();
            // navigator.Windows[WindowType.TodoCreate].Show();
            // navigator.Windows[WindowType.Chat].Show();
            navigator.Windows[WindowType.CreateConference].Show();
            navigator.Windows[WindowType.Conference].Show();
            
            mainWindow.Show();
        }
    }
}
