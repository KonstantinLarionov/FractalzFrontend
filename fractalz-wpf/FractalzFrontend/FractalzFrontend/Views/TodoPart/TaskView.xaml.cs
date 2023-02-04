using FractalzFrontend.Models.TodoPart;
using FractalzFrontend.ViewModels.TodoPart;

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
    /// Логика взаимодействия для TaskView.xaml
    /// </summary>
    public partial class TaskView : UserControl
    {
        public string Header
        {
            get { return (string)GetValue(HeaderProperty); }
            set { SetValue(HeaderProperty, value); }
        }

        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(
                                "Header",
                                typeof(string), typeof(TaskView));

        //    public TaskVM vm
        //    {
        //        get {
        //            return (TaskVM)GetValue(ComponentProperty);
        //        }
        //        set { 
        //            SetValue(ComponentProperty, value); }
        //    }
        //private TaskModel _model;
        public TaskView()
        {
            InitializeComponent();
            //_model = new TaskModel(vm);
            //DataContext = vm;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
