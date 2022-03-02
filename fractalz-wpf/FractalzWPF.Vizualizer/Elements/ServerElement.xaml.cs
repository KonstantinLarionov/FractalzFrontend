using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FractalzWPF.Infrastructure.Vizualizer.Elements
{
    public partial class ServerElement : UserControl
    {
        public ServerElement()
        {
            InitializeComponent();
            for (int i = 1; i < 10; i++)
            {
                treeViewRooms.Items.Add(CreateUIRoom(i, "RandomName" + i));
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            tree.Visibility = tree.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        }


        public ContextMenu CreateMenuRoom(string id)
        {
            var cm = new ContextMenu();
            var mi = new MenuItem();
            mi.Header = "Подключиться";
            mi.Tag = id;
            mi.Click += MiOnMouseDown;
            cm.Items.Add(mi);
            return cm;
        }

        private void MiOnMouseDown(object sender, RoutedEventArgs e)
        {
            var mi = (MenuItem) sender;
            MessageBox.Show(mi.Tag.ToString());
        }

        public TreeViewItem CreateUIRoom(int id, string name)
        {
            var room = new TreeViewItem()
            {
                Tag = id.ToString(),
                Header = name,
                ContextMenu = CreateMenuRoom(id.ToString())
            };
            return room;
        }
    }
}