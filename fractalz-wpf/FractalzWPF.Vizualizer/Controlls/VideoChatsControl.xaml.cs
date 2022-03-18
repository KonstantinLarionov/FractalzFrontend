using System;
using System.Windows.Controls;
using FractalzWPF.Infrastructure.Vizualizer.Elements;

namespace FractalzWPF.Infrastructure.Vizualizer.Controlls
{
    public partial class VideoChatsControl : UserControl
    {
        public VideoChatsControl()
        {
            InitializeComponent();
            for (int i = 0; i < 30; i++)
            {
                conferenceSpace.Children.Add(new ConferenceElement(i, $"Daily conference №{i}", DateTime.Now));
            }
        }
        
        
    }
}