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
using FractalzFrontend.Models.DialogsPart;
using FractalzFrontend.ViewModels.DialogsPart;

namespace FractalzFrontend.Views.ChatPart
{
    /// <summary>
    /// Логика взаимодействия для DialogsView.xaml
    /// </summary>
    public partial class DialogsView : UserControl
    {
        private DialogsVM _dialogsVm = new DialogsVM();
        private DialogsModel _dialogsModel;
        public DialogsView()
        {
            InitializeComponent();
            DataContext = _dialogsVm;
            _dialogsModel = new DialogsModel(_dialogsVm);
            _dialogsVm.AddValue(new DialogVM()
            {
                Account = "Константин Ларионов",
                DateTime = DateTime.Now,
                Id = new Guid(),
                IsP2P = true,
                LastMessage = "Последнее тестовое сообщение",
                OnlineStatus = new SolidColorBrush(Colors.Green),
                IsRead = true,
            }); _dialogsVm.AddValue(new DialogVM()
            {
                Account = "kostya12277",
                DateTime = DateTime.Now,
                Id = new Guid(),
                IsP2P = true,
                LastMessage = "Последнее тестовое сообщение Последнее тестовое сообщение",
                OnlineStatus = new SolidColorBrush(Colors.Red),
                IsRead=false,
            });

        }

        private void FindUser(object sender, RoutedEventArgs e)
        {
            _dialogsModel.GetDialogUser();
        }
    }
}
