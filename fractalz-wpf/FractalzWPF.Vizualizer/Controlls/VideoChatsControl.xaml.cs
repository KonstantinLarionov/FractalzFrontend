using System;
using System.Windows;
using System.Windows.Controls;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Events;
using FractalzWPF.Infrastructure.Vizualizer.Elements;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer.Controlls
{
    public partial class VideoChatsControl : UserControl
    {
        private readonly NotifyHandler _notifyHandler;
        private readonly INavigatorHandlers _navigator;
        private readonly INavigatorControls _controls;

        public VideoChatsControl(NotifyHandler notifyHandler, INavigatorHandlers navigator, INavigatorControls controls)
        {
            InitializeComponent();
            _notifyHandler = notifyHandler;
            _navigator = navigator;
            _controls = controls;
            
            ConferenceEvents.CreateEvent += ConferenceEventsOnCreateEvent;
            ConferenceEvents.DeleteEvent += ConferenceEventsOnDeleteEvent;
        }

        private void ConferenceEventsOnDeleteEvent(UserControl task) => conferenceSpace.Children.Remove(task);

        private void ConferenceEventsOnCreateEvent(UserControl task) => conferenceSpace.Children.Add(task);

        private void VideoChatsControl_OnLoaded(object sender, RoutedEventArgs e) => UpdateSpace();

        private void UpdateSpace()
        {
            conferenceSpace.Children.Clear();
            var response = _navigator.GetMyConferenceHandler.Do(_navigator.UserData.Id);
            if (!response.Success)
            {
                _notifyHandler.Show("Проблемы с получением данных", response.Message, null, NotificationType.Error);
                return;
            }

            var conferences = response.Conferences;
            foreach (var conference in conferences)
            {
                Dispatcher.BeginInvoke((Action) delegate
                {
                    if (conference.DateTimeStart != null)
                        conferenceSpace.Children.Add(new ConferenceElement(conference.Id, conference.Name,
                            conference.DateTimeStart.Value));
                });
            }
        }
    }
}