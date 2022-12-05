using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.Views.ChatPart;
using FractalzFrontend.Views.NotifyPart;
using FractalzFrontend.Views.ProfilePart;
using FractalzFrontend.Views.TodoPart;

using Ninject;

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
using System.Windows.Shapes;
using FractalzFrontend.Cache;
using FractalzFrontend.Models;

namespace FractalzFrontend.Views
{
    /// <summary>
    /// Логика взаимодействия для Layout.xaml
    /// </summary>
    public partial class Layout : Window
    {
        private readonly MainWindow main;
        private ProfileView profileView;
        private DialogsView dialogsView;
        private NotifyView notifyView;
        private TodoView todoView;
        private ICacheController _cache;
        private LayoutModel model;

        public Layout(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
            model = new LayoutModel(_cache);
            profileView = new ProfileView();
            dialogsView = new DialogsView();
            notifyView = new NotifyView();
            todoView = new TodoView();
            space.Children.Clear();
            space.Children.Add(profileView);
        }

        private void SwitchSpace(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            switch (button.Name)
            {
                case "burger":
                    //leftbar.Visibility = Visibility.Collapsed;
                    break;
                case "profile":
                    space.Children.Clear();
                    space.Children.Add(profileView);
                    break;
                case "chat":
                    space.Children.Clear();
                    space.Children.Add(dialogsView);
                    break;
                case "videochat":
                    break;
                case "events":
                    break;
                case "todo":
                    space.Children.Clear();
                    space.Children.Add(todoView);
                    break;
                case "notify":
                    space.Children.Clear();
                    space.Children.Add(notifyView);
                    break;
                case "docs":
                    break;
                case "exit":
                    main.Visibility = Visibility.Visible;
                    model.ClearCache();
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
