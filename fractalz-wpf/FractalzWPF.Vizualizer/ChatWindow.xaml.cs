using FractalzWPF.Infrastructure.Vizualizer.Elements;

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
    /// Логика взаимодействия для ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {
        public int DialogId { get; set; }
        private readonly INavigatorHandlers _navigator;
        private readonly NotifyHandler _noty;
        public ChatWindow(INavigatorHandlers navigatorHandlers, NotifyHandler noty)
        {
            InitializeComponent();
            _navigator = navigatorHandlers ?? throw new ArgumentException(nameof(navigatorHandlers));
            _noty = noty ?? throw new ArgumentException(nameof(noty));
        }

        private void ChatWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            var data = _navigator.GetMessageHistoryHandler.Do(
                this.DialogId, DateTime.Now.AddDays(-7), 100);
            if (data.Success)
            {
                var messages = data.Messages;
                foreach (var messageData in messages)
                {
                    var el = new MessageElement();
                    this.messagesSpace.Children.Add(el);
                }
            }
            else
            {
                _noty.Show("Ошибка получения истории сообщений", data.Message, null, NotificationType.Error);
            }
        }
    }
}
