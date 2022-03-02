using System.Windows;
using System.Windows.Controls;

namespace FractalzWPF.Infrastructure.Vizualizer.Elements
{
    public partial class ServerElement : UserControl
    {
        public ServerElement()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            tree.Visibility = tree.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }
    }
}