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

namespace FractalzWPF.Infrastructure.Vizualizer
{
    /// <summary>
    /// Логика взаимодействия для TodoCreateWindow.xaml
    /// </summary>
    public partial class TodoCreateWindow : Window
    {
        public TodoCreateWindow()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToShortDateString();
            time.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
