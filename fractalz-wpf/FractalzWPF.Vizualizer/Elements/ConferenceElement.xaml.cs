using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Events;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer.Elements
{
    public partial class ConferenceElement : UserControl
    {
        private readonly INavigatorHandlers _navigator;
        private readonly NotifyHandler _noty;
        public int Id { get; set; }

        public ConferenceElement(INavigatorHandlers navigator, NotifyHandler noty, int id, string name, DateTime dateStart)
        {
            InitializeComponent();
            _navigator = navigator;
            _noty = noty;
            Id = id;
            letterConferense.Content = name[0].ToString().ToUpper();
            tb_name.Text = name;
            tb_dateMessage.Text = dateStart.ToString("dd.MM") + " " + dateStart.ToShortTimeString();
            var menu = new MenuItem()
            {
                Header = "Удалить конференцию"
            };
            menu.Click += MenuOnClick;
            this.ContextMenu = new ContextMenu()
            {
                Items = { menu }
            };
            this.MouseDown += OnMouseDown;
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void MenuOnClick(object sender, RoutedEventArgs e)
        {
            var result = _navigator.DeleteConferenceHandler.Do(_navigator.UserData.Id, Id);
            if (result.Success)
            {
                ConferenceEvents.DeleteEventInvoke(this);
                _noty.Show("Конференция успешно удалена", "", null, NotificationType.Success);
            }
            else
            { 
                _noty.Show("Проблемы с удалением конференции", result.Message, null, NotificationType.Error);
            }
        }

        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            Background = new SolidColorBrush(Color.FromRgb(220,220,220));
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            Background = new SolidColorBrush(Colors.Transparent);
        }
    }
}