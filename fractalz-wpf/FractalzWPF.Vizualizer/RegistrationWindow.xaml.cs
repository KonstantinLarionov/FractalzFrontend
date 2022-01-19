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
using FractalzWPF.Application.Domains.Responses.User;
using FractalzWPF.Infrastructure.Application.Application;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private readonly INavigatorHandlers _handlers;
        public RegistrationWindow(INavigatorHandlers handlers)
        {
            InitializeComponent();
            _handlers = handlers;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (pass.Password == repass.Password)
            {
                var result = _handlers.RegistrationHandler.Do(login.Text, email.Text, pass.Password);
                if (result.Success)
                {
                    MessageBox.Show("Подтвердите регистрацию на почте!");
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
                
            }
            else
            {
                //TODO: пароли не верны
            }
        }
    }
}
