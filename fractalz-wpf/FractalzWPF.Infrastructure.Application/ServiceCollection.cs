using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Handlers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Infrastructure.Application
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<GetStringTestHandler>();
            serviceCollection.AddSingleton<INavigator, Navigator>();
        }
    }
}
