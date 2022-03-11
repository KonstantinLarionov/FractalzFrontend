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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FractalzWPF.Application.Domains.Entities.Chat;
using FractalzWPF.Application.Domains.Entities.Profile;
using FractalzWPF.Infrastructure.Application.Application;
using Notifications.Wpf;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    /// <summary>
    /// Логика взаимодействия для DialogsUserControl.xaml
    /// </summary>
    public partial class DialogsUserControl : UserControl
    {
        private readonly INavigatorHandlers _handlers;
        private readonly NotifyHandler _noty;
        private readonly ILinkedEventService _linkedEventService;
        private readonly INavigatorControls _navigatorControls;
        public DialogsUserControl(INavigatorHandlers handlers, NotifyHandler noty, ILinkedEventService linkedEventService, INavigatorControls controls)
        {
            InitializeComponent();
            _handlers = handlers ?? throw new ArgumentException(nameof(handlers));
            _noty = noty ?? throw new ArgumentException(nameof(noty));
            _linkedEventService = linkedEventService ?? throw new ArgumentException(nameof(linkedEventService));
            _navigatorControls = controls ?? throw new ArgumentException(nameof(controls));
            _linkedEventService.DialogUpdateEvent += LinkedEventServiceOnDialogUpdateEvent;
        }

        private void LinkedEventServiceOnDialogUpdateEvent(Dialog dialog)
        {
            var elements = dialogsSpace.Children;
            foreach (DialogElement element in elements)
            {
                if (element.Id != dialog.Id)
                { continue; }
                
                element.SetDataWithoutFio(dialog.LastMessage.Text, dialog.LastMessage.Created, dialog.CountUnReadMessage);
            }
        }

        private void DialogsUserControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            var dialogs = _handlers.GetDialogsHandler.Do(_handlers.UserData.Id);
            if (dialogs is null || !dialogs.Success)
            {
                _noty.Show("Проблемы с диалогами!",dialogs?.Message, null, NotificationType.Error);
                return;
            }

            foreach (var dialog in dialogs.Dialogs)
            {
                dialogsSpace.Children.Add(new DialogElement(dialog.Id, 
                    GetDialogName(dialog.Users), 
                    dialog.LastMessage.Text, 
                    dialog.Created, 
                    dialog.CountUnReadMessage, 
                    _navigatorControls));
            }
        }

        public string GetDialogName(List<User> usersFromDialog)
        {
            var usersWithoutMe = usersFromDialog
                .Where(x => x.Id != _handlers.UserData.Id)
                .ToList();
            var nameDialog = string.Empty;
            foreach (var user in usersWithoutMe)
            {
                nameDialog = string.Join(", ", nameDialog, GetUserName(user));
            }

            return nameDialog;
        }
        private string GetUserName(User user)
        {
            if (user.Name != null &&
                user.Surname != null &&
                user.Surname != string.Empty &&
                user.Name != string.Empty)
            {
                return $"{user.Name} {user.Surname}";
            }

            return user.Login;
        }
    }
}
