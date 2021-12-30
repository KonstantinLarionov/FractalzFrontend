using FractalzWPF.Infrastructure.Application.Application;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Infrastructure.Connector
{
    public static class InfrastructureServiceCollection
    {
        public static void AddInfrastructureConnector(this ServiceCollection services)
        {
            services.AddTransient<IConnector, Connector>();
        }
    }
}
