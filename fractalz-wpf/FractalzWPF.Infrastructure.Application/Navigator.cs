using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Infrastructure.Application.Handlers.Todo;
using FractalzWPF.Infrastructure.Application.Handlers.User;

namespace FractalzWPF.Infrastructure.Application
{
    public class Navigator : INavigatorHandlers
    {
        public int UserId { get; set; } = 2;
        public RegistrationHandler RegistrationHandler { get; set; }
        public GetTodoListHandler GetTodoListHandler { get; set; }
        public CreateTaskHandler CreateTaskHandler { get; set; }
        public DeleteTaskHandler DeleteTaskHandler { get; set; }
        public UpdateStatusTaskHandler UpdateStatusTaskHandler { get; set; }

        public Navigator(RegistrationHandler regHandler, 
            GetTodoListHandler getTodoListHandler, 
            CreateTaskHandler createTaskHandler, 
            DeleteTaskHandler deleteTaskHandler, 
            UpdateStatusTaskHandler updateStatusTaskHandler)
        {
            RegistrationHandler = regHandler;
            GetTodoListHandler = getTodoListHandler;
            CreateTaskHandler = createTaskHandler;
            DeleteTaskHandler = deleteTaskHandler;
            UpdateStatusTaskHandler = updateStatusTaskHandler;
        }
    }
}
