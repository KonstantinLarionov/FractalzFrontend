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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FractalzWPF.Infrastructure.Application.Events;
using FractalzWPF.Infrastructure.Application.Handlers.Todo;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer.Elements
{
    /// <summary>
    /// Логика взаимодействия для TodoElement.xaml
    /// </summary>
    public partial class TodoElement : UserControl
    {
        public int _id;
        private DeleteTaskHandler _deleter;
        private UpdateStatusTaskHandler _updater;
        private NotifyHandler _notify;
        
        public TodoElement(int id, string title, string desc, bool isCompleted, DateTime start, int durationInMinute,
            DeleteTaskHandler deleter,
            UpdateStatusTaskHandler updater,
            NotifyHandler notifyer)
        {
            InitializeComponent();

            _id = id;
            _notify = notifyer;
            _deleter = deleter;
            _updater = updater;
            titleTask.Text = title + $" [{start.ToShortTimeString()} - {start.AddMinutes(durationInMinute).ToShortTimeString()}]";
            descTask.Text = desc;
            checkBoxTask.IsChecked = isCompleted;
        }


        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var res = _updater.Do(_id, !checkBoxTask.IsChecked.Value);
            if (res.Success)
            {
                _notify.Show(MessageResource.TaskUpdateSuccess, null,null, NotificationType.Success);
                checkBoxTask.IsChecked = !checkBoxTask.IsChecked;
            }
            else
            {
                _notify.Show(MessageResource.TaskUpdateError, res.Message, null, NotificationType.Error);
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var res = _deleter.Do(_id);
            if (!res.Success)
            {
                _notify.Show(MessageResource.TaskDeleteError, res.Message, null, NotificationType.Error);
            }
            else
            {
                TodoEvents.DeleteEventInvoke(this);
            }
        }
    }
}
