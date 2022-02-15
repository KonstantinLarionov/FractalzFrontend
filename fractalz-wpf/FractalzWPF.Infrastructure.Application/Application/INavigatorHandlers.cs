using FractalzWPF.Infrastructure.Application.Handlers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Handlers.Chat;
using FractalzWPF.Infrastructure.Application.Handlers.Todo;
using FractalzWPF.Infrastructure.Application.Handlers.User;

namespace FractalzWPF.Infrastructure.Application.Application
{
    public interface INavigatorHandlers
    {        
        public UserData UserData { get; set; }
        public GetTodoListHandler GetTodoListHandler { get; set; }
        public CreateTaskHandler CreateTaskHandler { get; set; }
        public DeleteTaskHandler DeleteTaskHandler { get; set; }
        public UpdateStatusTaskHandler UpdateStatusTaskHandler { get; set; }
        public RegistrationHandler RegistrationHandler { get; set; }
        public LoginHandler LoginHandler { get; set; }
        public GetMessageHistoryHandler GetMessageHistoryHandler { get; set; }

    }
}
