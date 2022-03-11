using FractalzWPF.Infrastructure.Vizualizer.Elements;
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
using FractalzWPF.Application.Domains.Entities.Todo;
using FractalzWPF.Infrastructure.Application;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Events;
using FractalzWPF.Infrastructure.Application.Handlers.Todo;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    /// <summary>
    /// Логика взаимодействия для TodoUserControl.xaml
    /// </summary>
    public partial class TodoUserControl : UserControl
    {
        private NotifyHandler _notifyHandler;
        private INavigatorHandlers _navigator;
        private TodoList _todoList;

        private int _countAll = 0;
        private int CountAll
        {
            get { return _countAll;}
            set
            {
                _countAll = value;
                tb_countAllTask.Text = _countAll.ToString();
            }
        }
        private int _countOpen = 0;
        private int CountOpen
        {
            get { return _countOpen; }
            set
            {
                _countOpen = value;
                tb_countAllOpenTask.Text = _countOpen.ToString();
            }
        }

        private int _countToday = 0;
        private int CountToday
        {
            get { return _countToday; }
            set
            {
                _countToday = value;
                tb_countTodayTask.Text = _countToday.ToString();
            }
        }

        public TodoUserControl(NotifyHandler notifyHandler, INavigatorHandlers navigator)
        {
            InitializeComponent();
            TodoEvents.DeleteEvent += TodoEventsOnDeleteEvent;
            TodoEvents.CreateEvent += TodoEventsOnCreateEvent;
            _notifyHandler = notifyHandler;
            _navigator = navigator;
            
        }

        private void ShowTodoList()
        {
            sp_todoList.Children.Clear();
            foreach (var task in _todoList.Tasks)
            {
                var el = new TodoElement(task.Id, task.Header, task.About, task.IsCompleted, task.DateCreate, task.DurationInMinute,
                    _navigator.DeleteTaskHandler, _navigator.UpdateStatusTaskHandler, _notifyHandler);
                sp_todoList.Children.Add(el);
            }
        }

        private void TodoEventsOnDeleteEvent(UserControl task)
        {
            BuildData();
            sp_todoList.Children.Remove(task);
        }

        private void TodoEventsOnCreateEvent(UserControl task)
        {
            BuildData();
            sp_todoList.Children.Insert(0, task);
        }

        private void TodoUserControl_OnLoaded(object sender, RoutedEventArgs e) =>
            BuildData();
        private void BuildData()
        {
            var rat = _navigator.GetTodoListHandler.Do(_navigator.UserData.Id, DateTime.Now.AddDays(-7));
            if (rat.Success)
            {
                _todoList = rat.TodoList;
                CountAll = rat.TodoList.Tasks.Count;
                CountToday = rat.TodoList.Tasks
                    .Count(x => x.DateCreate.Date == DateTime.Now.Date);
                CountOpen = rat.TodoList.Tasks
                    .Count(x => x.IsCompleted == false);
                ShowTodoList();
            }
            else
            {
                _notifyHandler.Show(MessageResource.TodoGetErrorTitle, rat.Message, null, NotificationType.Error);
            }
        }
    }
}
