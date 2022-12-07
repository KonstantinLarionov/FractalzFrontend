using FractalzFrontend.Models.LoginPart;
using FractalzFrontend.ViewModels.LoginPart;

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

namespace FractalzFrontend.Views.LoginPart
{
    /// <summary>
    /// Логика взаимодействия для RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : UserControl
    {
        private readonly MainWindow main;
        public readonly RegistrationVM _vm = new RegistrationVM();
        public readonly RegistrationModel _model;
        public RegistrationView(MainWindow main)
        {
            InitializeComponent();

            _model = new RegistrationModel(_vm);
            DataContext = _vm;
            this.main = main;
        }

        private void In_MouseDown(object sender, MouseButtonEventArgs e) => main.SwtichSpace(0);
        

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            var response = _model.RegistrationRequest();

            var responseCode = _model.SendCodeRequest();

            if (responseCode.Success && response.Success)
            {
                if (response.Success)
                {
                    MessageBox.Show("Вы успешно зарегистрировались в системе Леттер.\r\nПодтвердите аккаунт.");
                    main.SwtichSpace(5);
                }
                else
                {
                    MessageBox.Show(
                        response.Message,
                        "Регистрация аккаунта",
                        button: MessageBoxButton.OK,
                        icon: MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Проблемы с отправкой кода, возможно почта уже существует в системе",
                    "Регистрация аккаунта",
                    button: MessageBoxButton.OK,
                    icon: MessageBoxImage.Error);
            }

        }
    }
}
