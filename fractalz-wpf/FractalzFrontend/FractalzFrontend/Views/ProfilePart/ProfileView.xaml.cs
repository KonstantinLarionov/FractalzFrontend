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
using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.Cache;
using FractalzFrontend.Models;
using FractalzFrontend.Models.ProfilePart;
using FractalzFrontend.ViewModels.ProfilePart;
using Ninject;

namespace FractalzFrontend.Views.ProfilePart
{
    /// <summary>
    /// Логика взаимодействия для ProfileView.xaml
    /// </summary>
    public partial class ProfileView : UserControl
    {
        private ProfileVM _profileVm = new ProfileVM();
        private readonly ProfileModel _profileModel;
        public ProfileView()
        {
            InitializeComponent();
            _profileModel = new ProfileModel(_profileVm);
            DataContext = _profileVm;
            _profileModel.GetUser();
        }

        private void UpdateUserInfo(object sender, RoutedEventArgs e)
        {
            var upd = _profileModel.UpdateUserInfo();
            if (upd.Success)
            {
                MessageBox.Show("Изменения успешно сохранены"); 
            }
            else
            {
                MessageBox.Show("Произошла ошибка! Проверьте правильность введенных данных!");
            }
        }
    }
}
