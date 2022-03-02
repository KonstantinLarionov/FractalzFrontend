using System.Windows.Controls;
using FractalzWPF.Infrastructure.Vizualizer.Elements;

namespace FractalzWPF.Infrastructure.Vizualizer
{
    public partial class VoiceControl : UserControl
    {
        public VoiceControl()
        {
            InitializeComponent();
            my_space.Children.Add(new ServerElement());
            my_space.Children.Add(new ServerElement());
            my_space.Children.Add(new ServerElement());
            my_space.Children.Add(new ServerElement());
            my_space.Children.Add(new ServerElement());
            
            other_space.Children.Add(new ServerElement());
            other_space.Children.Add(new ServerElement());
            other_space.Children.Add(new ServerElement());
            other_space.Children.Add(new ServerElement());
            other_space.Children.Add(new ServerElement());
        }
    }
}