using FractalzWPF.Infrastructure.Application.Application;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructureVisualizer(this ServiceCollection services)
        {
            services.AddSingleton<INavigatorControls, NavigatorControls>();
            services.AddSingleton<NotifyHandler>();
        }
    }
}
