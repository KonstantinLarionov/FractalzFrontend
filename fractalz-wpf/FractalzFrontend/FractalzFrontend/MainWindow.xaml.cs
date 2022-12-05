using FractalzFrontend.Views.LoginPart;

using Ninject;

using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace FractalzFrontend
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LoginView loginView;
        private RegistrationView registrationView;
        private ResetAccountView resetAccountView;
        private ResetPasswordView resetPasswordView;
        private SignView signView;
        private CodeValidateView codeValidateView;
        public MainWindow()
        {
            InitializeComponent();

            loginView = new LoginView(this);
            registrationView = new RegistrationView(this);
            resetAccountView = new ResetAccountView(this);
            resetPasswordView = new ResetPasswordView(this);
            codeValidateView = new CodeValidateView(this, registrationView._model, registrationView._vm);
            signView = new SignView(this);

            space.Children.Clear();
            space.Children.Add(loginView);
        }

        public void SwtichSpace(int number)
        {
            space.Children.Clear();
            switch (number)
            {
                case 0:
                    space.Children.Add(loginView);
                    break;
                case 1:
                    space.Children.Add(registrationView);
                    break;
                case 2:
                    space.Children.Add(resetAccountView);
                    break;
                case 3:
                    space.Children.Add(resetPasswordView);
                    break;
                case 4:
                    space.Children.Add(signView);
                    break;
                case 5:
                    space.Children.Add(codeValidateView);
                    break;
                default:
                    break;
            }
        }

    }
}
