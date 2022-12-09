using System.Windows;
using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.ViewModels.ProfilePart;

namespace FractalzFrontend.Views.ProfilePart.Modals
{
    public partial class ProfileLinksModal : Window
    {
        private ProfileVM _profileVm;
        private readonly ICacheController _cacheController;

        public ProfileLinksModal( string Vklink, string Tglink, ProfileVM profileVm)
        {
            InitializeComponent();
            _profileVm = profileVm;
            DataContext = _profileVm;
            VkBox.Text = Vklink;
            TgBox.Text = Tglink;
        }

        private void SaveLinks(object sender, RoutedEventArgs e)
        {
            _profileVm.VkLink = VkBox.Text;
            _profileVm.TgLink = TgBox.Text;
            var vis = Visibility = Visibility.Hidden;
            
        }
    }
}