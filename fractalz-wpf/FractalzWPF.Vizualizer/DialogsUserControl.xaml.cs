using FractalzWPF.Infrastructure.Vizualizer.Elements;

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

namespace FractalzWPF.Infrastructure.Vizualizer
{
    /// <summary>
    /// Логика взаимодействия для DialogsUserControl.xaml
    /// </summary>
    public partial class DialogsUserControl : UserControl
    {
        public DialogsUserControl()
        {
            InitializeComponent();
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
            dialogsSpace.Children.Add(new DialogElement());
        }
    }
}
