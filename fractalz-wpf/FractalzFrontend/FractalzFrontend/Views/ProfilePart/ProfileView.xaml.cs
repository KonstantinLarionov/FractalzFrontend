using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Fractalz.Application.Domains.Entities.Profile;
using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.Models;
using FractalzFrontend.Models.ProfilePart;
using FractalzFrontend.ViewModels.ProfilePart;
using FractalzFrontend.Views.ProfilePart.Modals;
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
        private readonly ICacheController _cacheController;
        private ProfileLinksModal _links;
        private string tglink;
        private string vklink;
        public ProfileView()
        {
            InitializeComponent();
            _profileModel = new ProfileModel(_profileVm);
            DataContext = _profileVm;
            _profileModel.GetUser();
            _cacheController = NinjectCollection
                .Cache
                .Services
                .Get<ICacheController>();
            tglink = _cacheController.GetCache<User>("User_Info").TGLink;
            vklink = _cacheController.GetCache<User>("User_Info").VKLink;
            _links = new ProfileLinksModal(vklink,tglink, _profileVm);
        }

        private async void UpdateUserInfo(object sender, RoutedEventArgs e)
        {
            var upd = await _profileModel.UpdateUserInfo();
            if (upd.Success)
            {
                MessageBox.Show("Изменения успешно сохранены"); 
            }
            else
            {
                MessageBox.Show("Произошла ошибка! Проверьте правильность введенных данных!");
            }
        }

        private void LinksModalOpen(object sender, MouseButtonEventArgs e)
        {
            if (_links.Visibility == Visibility.Collapsed)
            {
                _links.TgBox.Text = tglink;
                _links.VkBox.Text = vklink;
                _links.Show();
                
            }
            else
            {
                _links = new ProfileLinksModal(vklink, tglink, _profileVm);
                _links.Show();
            }
            
            
        }

    }
}
