using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    public class NavigatorControls : INavigatorControls
    {
        public Dictionary<UserControlType, UserControl> Controls { get; }
        public Dictionary<WindowType, Window> Windows { get; }
        public NavigatorControls()
        { 
            Controls = new Dictionary<UserControlType, UserControl>()
            {
                { UserControlType.Profile, new ProfileUserControl() },
                { UserControlType.Chat, new DialogsUserControl() },
                { UserControlType.Todo, new TodoUserControl() }
            };
            Windows = new Dictionary<WindowType, Window>()
            {
                { WindowType.Login, new LoginWindow() },
                { WindowType.Registration, new RegistrationWindow() },
                { WindowType.TodoCreate, new TodoCreateWindow() }
            };
        }
    }
}
