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

namespace FractalzWPF.Infrastructure.Vizualizer.Elements
{
    /// <summary>
    /// Логика взаимодействия для TodoElement.xaml
    /// </summary>
    public partial class TodoElement : UserControl
    {
        public TodoElement()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e) => 
            checkBox1.IsChecked = !checkBox1.IsChecked;
    }
}
