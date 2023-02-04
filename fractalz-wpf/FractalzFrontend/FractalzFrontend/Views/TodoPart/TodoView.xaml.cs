
using FractalzFrontend.Models.TodoPart;
using FractalzFrontend.ViewModels.TodoPart;
using FractalzFrontend.Views.TodoPart.Modals;

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

namespace FractalzFrontend.Views.TodoPart
{
    /// <summary>
    /// Логика взаимодействия для TodoView.xaml
    /// </summary>
    public partial class TodoView : UserControl
    {
        private TodoVM _vm = new TodoVM();
        private TodoModel _model;
        private CreateTask _createTask;

        public TodoView()
        {
            InitializeComponent();
            _model = new TodoModel(_vm);
            DataContext = _vm;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var result = _model.GetTasksByDateFrom();

            if (!result.Success)
                MessageBox.Show(result.Message);
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
            => _model.SortedByIsNotDone();

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
            => _model.SortedAll();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _createTask = new CreateTask(_model, _vm);
            _createTask.Show();
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            var ch_sender = (CheckBox)sender;

            if(ch_sender.IsChecked.HasValue)
                _model.UpdateTaskStatus(ch_sender.Tag.ToString(), ch_sender.IsChecked.Value);
        }

        private void DatePicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            _model.GetTasksByDateFrom();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var ch_sender = (Button)sender;

            _model.DeleteTask(ch_sender.Tag.ToString());
        }

        private void DockPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            var obj_sender = (DockPanel)sender;
            obj_sender.Children[0].Visibility = Visibility.Collapsed;
        }

        private void DockPanel_MouseEnter(object sender, MouseEventArgs e)
        {

            var obj_sender = (DockPanel)sender;
            obj_sender.Children[0].Visibility = Visibility.Visible;
        }
    }
}
