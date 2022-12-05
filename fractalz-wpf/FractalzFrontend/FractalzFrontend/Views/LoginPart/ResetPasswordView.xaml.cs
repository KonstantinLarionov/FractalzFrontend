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

namespace FractalzFrontend.Views.LoginPart
{
    /// <summary>
    /// Логика взаимодействия для ResetPasswordView.xaml
    /// </summary>
    public partial class ResetPasswordView : UserControl
    {
        private readonly MainWindow main;

        public ResetPasswordView(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void Code_Click(object sender, RoutedEventArgs e)
        {
            main.SwtichSpace(2);
        }

        private void Back_MouseDown(object sender, MouseButtonEventArgs e) => main.SwtichSpace(0);
    }
}
