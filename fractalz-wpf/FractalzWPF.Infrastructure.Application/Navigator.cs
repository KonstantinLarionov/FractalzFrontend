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
using FractalzWPF.Infrastructure.Application.Handlers.Voice;
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
        
        public AddOtherServerHandler AddOtherServerHandler { get; set; }
        public CreateMyServerHandler CreateMyServerHandler { get; set; }
        public CreateRoomHandler CreateRoomHandler { get; set; }
        public DeleteMyServerHandler DeleteMyServerHandler { get; set; }
        public DeleteRoomHandler DeleteRoomHandler { get; set; }
        public DelteUserFromRoomHandler DeleteUserFromRoomHandler { get; set; }
        public EditMyServerHandler EditMyServerHandler { get; set; }
        public EditRoomHandler EditRoomHandler { get; set; }
        public FindServerHandler FindServerHandler { get; set; }
        public GetMyServersHandler GetMyServersHandler { get; set; }
        public GetOtherServersHandler GetOtherServersHandler { get; set; }
        public GetRoomsHandler GetRoomsHandler { get; set; }
        public GetUsersRoomHandler GetUsersRoomHandler { get; set; }
        public InsertUserInRoomHandler InsertUserInRoomHandler { get; set; }

        public Navigator(RegistrationHandler regHandler, 
            GetTodoListHandler getTodoListHandler, 
            CreateTaskHandler createTaskHandler, 
            DeleteTaskHandler deleteTaskHandler, 
            UpdateStatusTaskHandler updateStatusTaskHandler,
            LoginHandler loginHandler,
            GetMessageHistoryHandler getMessageHistoryHandler,
            GetDialogsHandler getDialogsHandler,
            IOptions<UserData> userData,
            AddOtherServerHandler addOtherServerHandler,
            CreateMyServerHandler createMyServerHandler,
            CreateRoomHandler createRoomHandler,
            DeleteMyServerHandler deleteMyServerHandler,
            DeleteRoomHandler deleteRoomHandler,
            DelteUserFromRoomHandler deleteUserFromRoomHandler,
            EditMyServerHandler editMyServerHandler,
            EditRoomHandler editRoomHandler,
            FindServerHandler findServerHandler,
            GetMyServersHandler getMyServersHandler,
            GetOtherServersHandler getOtherServersHandler,
            GetRoomsHandler getRoomsHandler,
            GetUsersRoomHandler getUsersRoomHandler,
            InsertUserInRoomHandler insertUserInRoomHandler)
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
            AddOtherServerHandler = addOtherServerHandler;
            CreateMyServerHandler = createMyServerHandler;
            CreateRoomHandler = createRoomHandler;
            DeleteMyServerHandler = deleteMyServerHandler;
            DeleteRoomHandler = deleteRoomHandler;
            DeleteUserFromRoomHandler = deleteUserFromRoomHandler;
            EditMyServerHandler = editMyServerHandler;
            EditRoomHandler = editRoomHandler;
            FindServerHandler = findServerHandler;
            GetMyServersHandler = getMyServersHandler;
            GetOtherServersHandler = getOtherServersHandler;
            GetRoomsHandler = getRoomsHandler;
            GetUsersRoomHandler = getUsersRoomHandler;
            InsertUserInRoomHandler = insertUserInRoomHandler;
        }
    }
}
