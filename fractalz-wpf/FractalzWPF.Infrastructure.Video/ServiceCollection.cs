using FractalzWPF.Infrastructure.Application.Application;
using Microsoft.Extensions.DependencyInjection;

namespace FractalzWPF.Infrastructure.Video;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructureVideo(this ServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IVideoDispatcher, VideoDispatcher>();
    }

}