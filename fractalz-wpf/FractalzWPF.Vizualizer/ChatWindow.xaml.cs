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
using FractalzWPF.Application.Domains.Entities.Chat;
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
        public string DialogName { get; set; }
        private string _userName { get; set; }

        private readonly INavigatorHandlers _navigator;
        private readonly ILinkedEventService _linkedEventService;
        private readonly NotifyHandler _noty;
        public ChatWindow(INavigatorHandlers navigatorHandlers, NotifyHandler noty, ILinkedEventService linkedEventService)
        {
            InitializeComponent();
            _userName = GetUserName();
            _navigator = navigatorHandlers ?? throw new ArgumentException(nameof(navigatorHandlers));
            _linkedEventService = linkedEventService ?? throw new ArgumentException(nameof(linkedEventService));
            _noty = noty ?? throw new ArgumentException(nameof(noty));
            _linkedEventService.GetMessageEvent += LinkedEventServiceOnGetMessageEvent;
        }

        private void LinkedEventServiceOnGetMessageEvent(Message message)
        {
            if(message.DialogId != this.DialogId)
                return;
            
            var userName = _userName;
            if (_navigator.UserData.Id != message.IdSender)
                userName = this.DialogName;
                    
            var el = new MessageElement(userName, message.Text, message.Created);
            
            Dispatcher.BeginInvoke((Action)delegate { 
                this.messagesSpace.Children.Add(el);
                scroller.ScrollToBottom();
            });
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
                    var userName = _userName;
                    if (_navigator.UserData.Id != messageData.IdSender)
                        userName = this.DialogName;
                    
                    var el = new MessageElement(userName, messageData.Text, messageData.Created);
                    this.messagesSpace.Children.Add(el);
                }
                scroller.ScrollToBottom();
            }
            else
            {
                _noty.Show("Ошибка получения истории сообщений", data.Message, null, NotificationType.Error);
            }
        }

        private string GetUserName()
        {
            if (_navigator.UserData.Name != null &&
                _navigator.UserData.Surname != null &&
                _navigator.UserData.Surname != string.Empty &&
                _navigator.UserData.Name != string.Empty)
            {
                return $"{_navigator.UserData.Name} {_navigator.UserData.Surname}";
            }

            return _navigator.UserData.Login;
        }
    }
}
