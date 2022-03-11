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
using FractalzWPF.Infrastructure.Application.Application;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly INavigatorHandlers _handlers;
        private readonly NotifyHandler _noty;
        public LoginWindow(INavigatorHandlers handlers, NotifyHandler noty)
        {
            InitializeComponent();
            _handlers = handlers;
            _noty = noty;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var response = _handlers.LoginHandler.Do(tb_login.Text, tb_password.Password);
            if (response.Success)
            {
                _noty.Show("Добро пожаловать!", "Вы успешно вошли во Fractalz", null, NotificationType.Success);
                var responseStatus = _handlers.UserData;
                this.Hide();
            }
            else
            {
                _noty.Show("Что то пошло не так..", response.Message, null, NotificationType.Error);
            }
        }
    }
}
