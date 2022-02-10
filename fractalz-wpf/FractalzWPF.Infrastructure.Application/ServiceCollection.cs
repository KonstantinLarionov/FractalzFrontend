using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Handlers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Infrastructure.Application.Handlers.Todo;
using FractalzWPF.Infrastructure.Application.Handlers.User;

namespace FractalzWPF.Infrastructure.Application
{
    public static class SC
    { public static ServiceProvider provider; }
    
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this ServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<RegistrationHandler>();
            serviceCollection.AddTransient<LoginHandler>();
            serviceCollection.AddTransient<GetTodoListHandler>();
            serviceCollection.AddTransient<CreateTaskHandler>();
            serviceCollection.AddTransient<DeleteTaskHandler>();
            //serviceCollection.AddTransient<TodoBaseHandler>();
            serviceCollection.AddTransient<UpdateStatusTaskHandler>();
            serviceCollection.AddSingleton<INavigatorHandlers, Navigator>();
        }
    }
}
