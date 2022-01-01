﻿using System;
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

namespace FractalzWPF.Infrastructure.Vizualizer.Elements
{
    /// <summary>
    /// Логика взаимодействия для DialogElement.xaml
    /// </summary>
    public partial class DialogElement : UserControl
    {
        public DialogElement()
        {
            InitializeComponent();
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
