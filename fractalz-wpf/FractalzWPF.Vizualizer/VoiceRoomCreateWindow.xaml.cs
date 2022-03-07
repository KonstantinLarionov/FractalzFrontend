﻿using System.Windows;
using FractalzWPF.Infrastructure.Application.Application;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    public partial class VoiceRoomCreateWindow : Window
    {
        private readonly int _serverId;
        private readonly NotifyHandler _notifyHandler;
        private readonly INavigatorHandlers _navigator;

        public VoiceRoomCreateWindow(int serverId, NotifyHandler notifyHandler, INavigatorHandlers navigator)
        {
            InitializeComponent();
            _serverId = serverId; 
            _notifyHandler = notifyHandler;
            _navigator = navigator;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var result = _navigator.CreateRoomHandler.Do(nameRoom.Text, _serverId);
            if (result.Success)
            {
                _notifyHandler.Show("Создание комнаты", "Комната успешно создана", null, NotificationType.Success);
            }
            else
            {
                _notifyHandler.Show("Создание комнаты", "Не удалось создать комнату", null, NotificationType.Error);
            }
        }
    }
}