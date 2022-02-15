using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Events;
using FractalzWPF.Infrastructure.Application.Handlers.Todo;
using FractalzWPF.Infrastructure.Vizualizer.Elements;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    /// <summary>
    /// Логика взаимодействия для TodoCreateWindow.xaml
    /// </summary>
    public partial class TodoCreateWindow : Window
    {
        private CreateTaskHandler _handler;
        private DeleteTaskHandler _handlerD;
        private UpdateStatusTaskHandler _handlerU;
        private NotifyHandler _noty;
        public int _todoListId { get; set; } = 1;

        public TodoCreateWindow(NotifyHandler noty, INavigatorHandlers handlers)
        {
            InitializeComponent();
            
            _handler = handlers.CreateTaskHandler;
            _noty = noty;
            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToShortTimeString();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var duration = timeless.Text;
            var durationOnMinute = 0;

            if (duration.Contains('ч'))
            {
                duration = duration.Replace('ч', ' ').Trim();
                durationOnMinute = Convert.ToInt32(duration) * 60;
            }

            else if (duration.Contains('м'))
            {
                duration = duration.Replace('м', ' ').Trim();
                durationOnMinute = Convert.ToInt32(duration);
            }

            else if (duration.Contains('с'))
            {
                duration = duration.Replace('с', ' ').Trim();
                durationOnMinute = Convert.ToInt32(duration) / 60;
            }
            else
            {
                _noty.Show(MessageResource.TaskDurationErrorTitle, MessageResource.TaskDurationErrorDesc, null,
                    NotificationType.Warning);
                return;
            }

            var dateStart = DateTime.Parse(date.Text + " " + time.Text);
            var res = _handler.Do(_todoListId, title.Text, about.Text, dateStart,
                durationOnMinute);
            if (res.Success)
            {
                _noty.Show(MessageResource.TaskCreateSucces, title.Text, null, NotificationType.Success);
                TodoEvents.CreateEventInvoke(new TodoElement(res.IdTask, title.Text, about.Text, false,dateStart, durationOnMinute
                    , _handlerD,
                    _handlerU, _noty));
            }
            else
            {
                _noty.Show(MessageResource.TaskCreateError, res.Message, null, NotificationType.Error);
            }
        }
    }
}
