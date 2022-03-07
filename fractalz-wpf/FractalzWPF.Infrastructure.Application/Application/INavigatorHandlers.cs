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
using FractalzWPF.Infrastructure.Application.Handlers.Voice;

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
    }
}
