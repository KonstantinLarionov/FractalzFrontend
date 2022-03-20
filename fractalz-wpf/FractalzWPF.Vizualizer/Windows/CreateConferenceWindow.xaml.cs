using System;
using System.Collections.Generic;
using System.Windows;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Vizualizer.Elements;

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
            
            _handlers = handlers;
            _noty = noty;
            SetupInfo(id, name,token,dateStart, dayLoop,mainUser, otherUser);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            // var result = _handlers.CreateConferenceHandler.Do(_handlers.UserData.Id, confName.Text, confToken.Text, dateStart,  )
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