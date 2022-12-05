using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.Models;
using FractalzFrontend.Models.LoginPart;
using FractalzFrontend.ViewModels.LoginPart;

using Ninject;

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
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        private readonly MainWindow main;
        private readonly LoginVM _vm = new LoginVM();
        private readonly LoginModel _model;

        public LoginView(MainWindow main)
        {
            InitializeComponent();

            _model = new LoginModel(_vm);
            DataContext = _vm;
            this.main = main;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var response = _model.LoginRequest();
            if (response.Success)
            { 
                main.Visibility = Visibility.Collapsed;
                new Layout(main).Show();
            }
            else
                MessageBox.Show(response.Message);
        }

        private void CreateAccount_MouseDown(object sender, MouseButtonEventArgs e) =>
            main.SwtichSpace(1);

        private void ResetAccount_MouseDown(object sender, MouseButtonEventArgs e) =>
            main.SwtichSpace(3);

        private void Sign_MouseDown(object sender, MouseButtonEventArgs e) =>
            main.SwtichSpace(4);
    }
}
