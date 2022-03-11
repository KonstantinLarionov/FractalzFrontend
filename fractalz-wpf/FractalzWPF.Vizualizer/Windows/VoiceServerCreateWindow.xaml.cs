using System.Collections.Generic;
using System.Windows;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Events;
using FractalzWPF.Infrastructure.Vizualizer.Elements;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    public partial class VoiceServerCreateWindow : Window
    {
        private readonly INavigatorControls _controls;
        private readonly NotifyHandler _notifyHandler;
        private readonly INavigatorHandlers _navigator;

        public VoiceServerCreateWindow(INavigatorControls controls, NotifyHandler notifyHandler, INavigatorHandlers navigator)
        {
            InitializeComponent();
            _controls = controls;
            _notifyHandler = notifyHandler;
            _navigator = navigator;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var result = _navigator.CreateMyServerHandler.Do(nameServer.Text, _navigator.UserData.Id);
            if (result.Success)
            {
                _notifyHandler.Show("Создание сервера", "Сервер успешно создан", null, NotificationType.Success);
                VoiceServerEvents.CreateEventInvoke(new ServerElement(result.Server.Id, result.Server.Name, result.Server.Rooms,
                    new Dictionary<int, List<User>>(), _controls, _navigator,_notifyHandler));
                this.Hide();
            }
            else
            {
                _notifyHandler.Show("Создание сервера", result.Message, null, NotificationType.Error);
            }
        }
    }
}