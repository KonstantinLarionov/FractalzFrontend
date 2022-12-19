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
        private TaskVM _vm = new TaskVM();
        private TaskModel _taskModel;
        public TaskView()
        {
            InitializeComponent();

            _taskModel = new TaskModel(_vm);
            DataContext = _vm;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Motocicle 
    {
        public static Guid Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
    }

    public class MarketMoto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class MotocicleWithMarketMoto
    {
        public Guid Id { get; set; }
        public Motocicle.Guid IdMotocicle { get; set; }
        public MarketMoto.Guid IdMarketMoto { get; set; }
    }

}
