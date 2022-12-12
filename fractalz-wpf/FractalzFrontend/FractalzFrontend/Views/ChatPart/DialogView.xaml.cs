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
using FractalzFrontend.ViewModels.DialogsPart;

namespace FractalzFrontend.Views.ChatPart
{
    /// <summary>
    /// Логика взаимодействия для DialogView.xaml
    /// </summary>
    public partial class DialogView : UserControl
    {
        private DialogsVM _dialogsVm;
        public DialogView()
        {
            InitializeComponent();
            DataContext = _dialogsVm;
        }
    }
}
