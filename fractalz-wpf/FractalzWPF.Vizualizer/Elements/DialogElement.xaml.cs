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
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

namespace FractalzWPF.Infrastructure.Vizualizer.Elements
{
    /// <summary>
    /// Логика взаимодействия для DialogElement.xaml
    /// </summary>
    public partial class DialogElement : UserControl
    {
        private readonly INavigatorControls _navigatorControls;
        private int Id;
        private string _fio;
        public DialogElement(int id, string fio, string lastText, DateTime dateMessage, int countMessage, INavigatorControls navigatorControls)
        {
            InitializeComponent();
            _fio = fio;
            SetData(fio, lastText, dateMessage, countMessage);
            Id = id != 0 ? id : throw new ArgumentException(nameof(id));
            _navigatorControls = navigatorControls ?? throw new ArgumentException(nameof(navigatorControls));
        }

        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            Background = new SolidColorBrush(Color.FromRgb(220,220,220));
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            Background = new SolidColorBrush(Colors.Transparent);
        }

        private void SetData(string fio, string lastText, DateTime dateMessage, int countMessage)
        {
            tb_fio.Text = fio;
            tb_lastMessage.Text = lastText;
            tb_dateMessage.Text = dateMessage.ToShortTimeString();
            if (countMessage > 0)
            {
                tb_count.Text = countMessage.ToString();
                tb_fio.FontWeight = FontWeights.Bold;
                tb_lastMessage.FontWeight = FontWeights.Bold;
                tb_dateMessage.FontWeight = FontWeights.Bold;
            }
        }

        private void ClearElements()
        {
            tb_count.Text = string.Empty;
            tb_fio.FontWeight = FontWeights.Normal;
            tb_lastMessage.FontWeight = FontWeights.Normal;
            tb_dateMessage.FontWeight = FontWeights.Normal;
        }

        private void DialogElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ClearElements();
            
            var window = (ChatWindow)_navigatorControls.Windows[WindowType.Chat];
            window.DialogId = this.Id;
            window.DialogName = this._fio;
        }
    }
}
