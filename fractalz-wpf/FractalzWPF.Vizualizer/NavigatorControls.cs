using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using FractalzWPF.Application.Domains.Entities.Profile;
using Microsoft.Extensions.Options;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    public class NavigatorControls : INavigatorControls
    {
        public Dictionary<UserControlType, UserControl> Controls { get; }
        public Dictionary<WindowType, Window> Windows { get; }
        public NavigatorControls(INavigatorHandlers handlers, NotifyHandler noty, ILinkedEventService linkedEventService)
        { 
            Controls = new Dictionary<UserControlType, UserControl>()
            {
                { UserControlType.Profile, new ProfileUserControl() },
                { UserControlType.Chat, new DialogsUserControl(handlers, noty, linkedEventService, this) },
                { UserControlType.Todo, new TodoUserControl(noty, handlers) },
                { UserControlType.Voice, new VoiceControl(noty, handlers, this) }
            };
            Windows = new Dictionary<WindowType, Window>()
            {
                { WindowType.Login, new LoginWindow(handlers, noty) },
                { WindowType.Registration, new RegistrationWindow(handlers, noty) },
                { WindowType.TodoCreate, new TodoCreateWindow(noty, handlers) },
                { WindowType.Chat, new ChatWindow(handlers,noty,linkedEventService) },
                { WindowType.VoiceServer, new VoiceServerCreateWindow(this, noty, handlers) },
            };
        }
    }
}
