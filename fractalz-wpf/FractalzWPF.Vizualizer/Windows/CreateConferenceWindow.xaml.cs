using System;
using System.Collections.Generic;
using System.Windows;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Events;
using FractalzWPF.Infrastructure.Vizualizer.Elements;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer.Windows
{
    public partial class CreateConferenceWindow : Window
    {
        private readonly INavigatorHandlers _handlers;
        private readonly NotifyHandler _noty;
        private int? _id;
        public CreateConferenceWindow(INavigatorHandlers handlers, NotifyHandler noty,
            int? id = 0,
            string name = null, 
            string token= null, 
            DateTime? dateStart=null,
            bool? dayLoop=null, 
            List<User> mainUser=null, 
            List<User> otherUser=null)
        {
            InitializeComponent();
            
            this.dateStart.Text = DateTime.Now.ToShortDateString();
            this.timeStart.Text = DateTime.Now.ToShortTimeString();
            
            _handlers = handlers;
            _noty = noty;
            SetupInfo(id, name,token,dateStart, dayLoop,mainUser, otherUser);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var date = DateTime.Parse(dateStart.Text);
            var time = DateTime.Parse(timeStart.Text);
            DateTime dtStart = new DateTime(date.Year,date.Month, date.Day, time.Hour, time.Minute, time.Second);

            if (_id is null or 0)
            {
                var result = _handlers.CreateConferenceHandler.Do(_handlers.UserData.Id, confName.Text, confToken.Text,
                    dtStart, tb_dayLoop.IsChecked ?? false);
                if (result.Success)
                {
                    _noty.Show("Конференция успешно создалась!", "", null, NotificationType.Success);
                    var confElem = new ConferenceElement(_handlers, _noty,result.IdConference, confName.Text, dtStart);
                    ConferenceEvents.CreateEventInvoke(confElem);
                }
                else
                {
                    _noty.Show("Проблемы с созданием конференции", result.Message, null, NotificationType.Error);
                }
            }
            else if(_id.HasValue)
            {
                var result = _handlers.EditConferenceHandler.Do(_handlers.UserData.Id, dtStart,tb_dayLoop.IsChecked ?? false, _id.Value, confName.Text, confToken.Text);
            }
        }

        private void SetupInfo(int? id, string name, string token, DateTime? dateStartI, bool? dayLoop,
            List<User> mainUser,
            List<User> otherUser)
        {
            _id = id;
            confName.Text = name;
            confToken.Text = token;
            if (dateStartI != null)
            {
                dateStart.Text = dateStartI.Value.ToShortDateString();
                timeStart.Text = dateStartI.Value.ToShortTimeString();
            }
            tb_dayLoop.IsChecked = dayLoop;

            if (mainUser != null)
            {
                mainUsers.Children.Clear();
                foreach (var user in mainUser)
                {
                    mainUsers.Children.Add(new UserAddConferenceElement(user.Name, user.Surname, user.Patro, user.Login,
                        user.Email, user.Id));
                }
            }

            if (otherUser != null)
            {
                otherUsers.Children.Clear();
                foreach (var user in otherUser)
                {
                    otherUsers.Children.Add(new UserAddConferenceElement(user.Name, user.Surname, user.Patro,
                        user.Login,
                        user.Email, user.Id));
                }
            }
        }
    }
}