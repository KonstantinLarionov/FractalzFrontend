using System;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    public class NotifyHandler
    {
        private readonly NotificationManager _manager;
        public NotifyHandler()
        {
            _manager = new NotificationManager();
        }

        public void Show(string title, string text, string area, NotificationType type)
        {
            _manager.Show(new NotificationContent
            {
                Title = title,
                Message = text,
                Type = type
            }, expirationTime: TimeSpan.FromSeconds(5));
        }
    }
}