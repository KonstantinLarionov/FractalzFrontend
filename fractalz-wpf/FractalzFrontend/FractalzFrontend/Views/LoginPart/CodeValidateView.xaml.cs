using FractalzFrontend.Models.LoginPart;
using FractalzFrontend.ViewModels.LoginPart;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace FractalzFrontend.Views.LoginPart
{
    /// <summary>
    /// Логика взаимодействия для CodeValidateView.xaml
    /// </summary>
    public partial class CodeValidateView : UserControl
    {
        private readonly MainWindow main;
        private readonly RegistrationModel _model;

        public CodeValidateView(MainWindow main, RegistrationModel model, RegistrationVM vm)
        {
            InitializeComponent();

            _model = model;
            DataContext = vm;
            this.main = main;
        }

        private void In_MouseDown(object sender, MouseButtonEventArgs e) => main.SwtichSpace(1);

        private void Code_Click(object sender, RoutedEventArgs e)
        {
            var responseValid = _model.ValidCodeRequest();
            if (responseValid.Success)
            {
                main.SwtichSpace(0);
                MessageBox.Show("Аккаунт успешно подтвержден!");
            }
            else
                MessageBox.Show(
                    "Произошли проблемы при отправке кода",
                    "Отправка кода",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Error);
        }
    }
}
