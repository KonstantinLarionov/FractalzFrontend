using FractalzWPF.Infrastructure.Application.Application;
using Microsoft.Extensions.DependencyInjection;

namespace FractalzWPF.Infrastructure.LinkedEvent
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructureLinkedEvent(this IServiceCollection services)
        {
            services.AddSingleton<ILinkedEventService, LinkedEventService>();
        }
    }
}