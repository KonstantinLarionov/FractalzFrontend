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
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        private readonly INavigatorHandlers _handlers;
        private const string _notyTag = "noty";
        private readonly NotifyHandler _noty;

        public RegistrationWindow(INavigatorHandlers handlers, NotifyHandler noty)
        {
            InitializeComponent();
            _handlers = handlers;
            _noty = noty;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (pass.Password.Length < 6)
            {
                _noty.Show(
                    "Валидация формы",
                    "Пароль должен быть длиной больше чем 6 символов!",
                    _notyTag,
                    NotificationType.Error);
                return;
            }
            
            if (!pass.Password.Any(char.IsUpper))
            {
                _noty.Show(
                    "Валидация формы",
                    "В пароле должна быть хотя бы одна заглавная буква!",
                    _notyTag,
                    NotificationType.Error);
                return;
            }
            
            if (pass.Password != repass.Password)
            {
                _noty.Show(
                    "Валидация формы",
                    "Пароли на форме не совпадают!",
                    _notyTag,
                    NotificationType.Error);
                return;
            }
            
            if (!email.Text.Contains("@"))
            {
                _noty.Show(
                    "Валидация формы",
                    "Вы не ввели Email!",
                    _notyTag,
                    NotificationType.Error);
                return;
            }
            
            var result = _handlers.RegistrationHandler.Do(login.Text, email.Text, pass.Password);
            if (result.Success)
            {
                _noty.Show(
                    "Уведомление о регистрации",
                    "Регистрация прошла успешно!\n\rСсылка с подтверждением регистрации отправлена вам на почту",
                    _notyTag,
                    NotificationType.Success);
            }
            else
            {
                _noty.Show(
                    "Уведомление о регистрации",
                    "Не удалось зарегистрироваться!\n\r" + result.Message,
                    _notyTag,
                    NotificationType.Error);
            }
        }
    }
}
