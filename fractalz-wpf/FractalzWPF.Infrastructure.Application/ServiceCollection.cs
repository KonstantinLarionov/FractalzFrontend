using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Handlers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Infrastructure.Application.Handlers.Chat;
using FractalzWPF.Infrastructure.Application.Handlers.Conference;
using FractalzWPF.Infrastructure.Application.Handlers.Todo;
using FractalzWPF.Infrastructure.Application.Handlers.User;
using FractalzWPF.Infrastructure.Application.Handlers.Voice;

namespace FractalzWPF.Infrastructure.Application
{
    public static class SC
    { public static ServiceProvider provider; }
    
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this ServiceCollection serviceCollection)
        {
            #region [User]
            serviceCollection.AddTransient<RegistrationHandler>();
            serviceCollection.AddTransient<LoginHandler>();
            #endregion

            #region [Todo]
            serviceCollection.AddTransient<GetTodoListHandler>();
            serviceCollection.AddTransient<CreateTaskHandler>();
            serviceCollection.AddTransient<DeleteTaskHandler>();
            serviceCollection.AddTransient<UpdateStatusTaskHandler>();
            #endregion
            
            #region [MyRegion]
            serviceCollection.AddTransient<GetMessageHistoryHandler>();
            serviceCollection.AddTransient<GetDialogsHandler>();
            #endregion
            
            #region [Voice]
            serviceCollection.AddTransient<AddOtherServerHandler>();
            serviceCollection.AddTransient<CreateMyServerHandler>();
            serviceCollection.AddTransient<CreateRoomHandler>();
            serviceCollection.AddTransient<DeleteMyServerHandler>();
            serviceCollection.AddTransient<DeleteRoomHandler>();
            serviceCollection.AddTransient<DelteUserFromRoomHandler>();
            serviceCollection.AddTransient<EditMyServerHandler>();
            serviceCollection.AddTransient<EditRoomHandler>();
            serviceCollection.AddTransient<FindServerHandler>();
            serviceCollection.AddTransient<GetMyServersHandler>();
            serviceCollection.AddTransient<GetOtherServersHandler>();
            serviceCollection.AddTransient<GetRoomsHandler>();
            serviceCollection.AddTransient<GetUsersRoomHandler>();
            serviceCollection.AddTransient<InsertUserInRoomHandler>();
            #endregion

            #region [Conference]
            serviceCollection.AddTransient<AddUserInConferenceHandler>();
            serviceCollection.AddTransient<CreateConferenceHandler>();
            serviceCollection.AddTransient<DeleteConferenceHandler>();
            serviceCollection.AddTransient<DeleteUserFromConferenceHandler>();
            serviceCollection.AddTransient<EditConferenceHandler>();
            serviceCollection.AddTransient<FindConferenceHandler>();
            serviceCollection.AddTransient<GetMyConferenceHandler>();
            #endregion
            
            serviceCollection.AddSingleton<INavigatorHandlers, Navigator>();
        }
    }
}
