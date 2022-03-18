using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FractalzWPF.Infrastructure.Vizualizer.Elements
{
    public partial class ConferenceElement : UserControl
    {
        public int Id { get; set; }

        public ConferenceElement(int id, string name, DateTime dateStart)
        {
            InitializeComponent();
            Id = id;
            letterConferense.Content = name[0].ToString().ToUpper();
            tb_name.Text = name;
            tb_dateMessage.Text = dateStart.ToString("dd.MM") + " " + dateStart.ToShortTimeString();
        }
        
        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            Background = new SolidColorBrush(Color.FromRgb(220,220,220));
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            Background = new SolidColorBrush(Colors.Transparent);
        }
    }
}