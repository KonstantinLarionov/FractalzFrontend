using FractalzWPF.Infrastructure.Application;
using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Domains.Enums;

using Microsoft.Extensions.DependencyInjection;
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
using FractalzWPF.Application.Domains.Entities.Profile;
using Microsoft.Extensions.Options;

namespace FractalzWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly INavigatorControls _navigatorControls;
        private readonly INavigatorHandlers _navigatorHandlers;
        public MainWindow(INavigatorHandlers navigatorHandlers, INavigatorControls navigatorControls)
        {
            InitializeComponent();
            _navigatorControls = navigatorControls;
            _navigatorHandlers = navigatorHandlers;
            VideoChatLB_OnClick(this, new RoutedEventArgs());
        }

        private void profileLB_Click(object sender, RoutedEventArgs e) => Switcher(UserControlType.Profile);

        private void dialogsLB_Click(object sender, RoutedEventArgs e) => Switcher(UserControlType.Chat);

        private void todoLB_Click(object sender, RoutedEventArgs e) => Switcher(UserControlType.Todo);

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) => Switcher(UserControlType.Voice);
        
        private void VideoChatLB_OnClick(object sender, RoutedEventArgs e) => Switcher(UserControlType.VideoChats);
        
        private void Window_Closed(object sender, EventArgs e) => System.Windows.Application.Current.Shutdown();

        private void Switcher(UserControlType controlType)
        {
            mainSpace.Children.Clear();
            mainSpace.Children.Add(_navigatorControls.Controls[controlType]);
        }

    }
}
