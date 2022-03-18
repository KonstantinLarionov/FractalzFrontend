using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;
using FractalzWPF.Infrastructure.Application.Events;
using FractalzWPF.Infrastructure.Vizualizer.Elements;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    public partial class VoiceControl : UserControl
    {
        private readonly NotifyHandler _notifyHandler;
        private readonly INavigatorHandlers _navigator;
        private readonly INavigatorControls _controls;

        public VoiceControl(NotifyHandler notifyHandler, INavigatorHandlers navigator, INavigatorControls controls)
        {
            InitializeComponent();
            _notifyHandler = notifyHandler;
            _navigator = navigator;
            _controls = controls;
            
            VoiceServerEvents.CreateEvent += VoiceEventsOnCreateEvent;
            VoiceServerEvents.DeleteEvent += VoiceEventsOnDeleteEvent;
        }

        private void VoiceEventsOnDeleteEvent(UserControl task) =>
            my_space.Children.Remove(task);
        

        private void VoiceEventsOnCreateEvent(UserControl task) =>
            my_space.Children.Add(task);

        private void VoiceControl_OnLoaded(object sender, RoutedEventArgs e) => UpdateSpace();

        private void UpdateSpace()
        {
            my_space.Children.Clear();
            var my_servers = _navigator.GetMyServersHandler.Do(_navigator.UserData.Id);
            if (my_servers == null)
            {
                _notifyHandler.Show("Проблемы с загрузкой", "Не удалось загрузить голосовые сервера", null, NotificationType.Error);
                return;
            }

            if (my_servers.Success)
            {
                foreach (var server in my_servers.Servers)
                {
                    var rooms = _navigator.GetRoomsHandler.Do(server.Id);

                    Dictionary<int, List<User>> usersRoom = new Dictionary<int, List<User>>();
                    rooms.Rooms.ForEach(x =>
                    {
                        var result = _navigator.GetUsersRoomHandler.Do(x.Id);
                        if (result.Success)
                            usersRoom.Add(x.Id, result.Users);
                    });

                    if (rooms.Success)
                    {
                        Dispatcher.BeginInvoke((Action) delegate
                        {
                            my_space.Children.Add(new ServerElement(server.Id, server.Name, rooms.Rooms, usersRoom,
                                _controls, _navigator, _notifyHandler));
                        });
                    }
                    else
                    {
                        _notifyHandler.Show("Получение комнат", rooms.Message, null, NotificationType.Error);
                    }
                }
            }
            else
            {
                _notifyHandler.Show("Получение серверов", my_servers.Message, null, NotificationType.Error);
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            _controls.Windows[WindowType.VoiceServer].ShowDialog();
        }
    }
}