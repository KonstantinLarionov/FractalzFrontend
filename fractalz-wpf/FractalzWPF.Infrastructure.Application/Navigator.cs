using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Application.Domains.Responses.User;
using FractalzWPF.Infrastructure.Application.Handlers.Chat;
using FractalzWPF.Infrastructure.Application.Handlers.Todo;
using FractalzWPF.Infrastructure.Application.Handlers.User;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Application
{
    public class Navigator : INavigatorHandlers
    {
        public UserData UserData { get; set; }
        public RegistrationHandler RegistrationHandler { get; set; }
        public LoginHandler LoginHandler { get; set; }
        public GetTodoListHandler GetTodoListHandler { get; set; }
        public CreateTaskHandler CreateTaskHandler { get; set; }
        public DeleteTaskHandler DeleteTaskHandler { get; set; }
        public UpdateStatusTaskHandler UpdateStatusTaskHandler { get; set; }
        public GetMessageHistoryHandler GetMessageHistoryHandler { get; set; }
        public GetDialogsHandler GetDialogsHandler { get; set; }

        public Navigator(RegistrationHandler regHandler, 
            GetTodoListHandler getTodoListHandler, 
            CreateTaskHandler createTaskHandler, 
            DeleteTaskHandler deleteTaskHandler, 
            UpdateStatusTaskHandler updateStatusTaskHandler,
            LoginHandler loginHandler,
            GetMessageHistoryHandler getMessageHistoryHandler,
            GetDialogsHandler getDialogsHandler,
            IOptions<UserData> userData)
        {
            UserData = userData.Value ?? throw new ArgumentException(nameof(userData));
            GetMessageHistoryHandler = getMessageHistoryHandler;
            LoginHandler = loginHandler;
            RegistrationHandler = regHandler;
            GetTodoListHandler = getTodoListHandler;
            CreateTaskHandler = createTaskHandler;
            DeleteTaskHandler = deleteTaskHandler;
            UpdateStatusTaskHandler = updateStatusTaskHandler;
            GetDialogsHandler = getDialogsHandler;
        }
    }
}
