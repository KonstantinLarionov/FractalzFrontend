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
    /// Логика взаимодействия для MessageElement.xaml
    /// </summary>
    public partial class MessageElement : UserControl
    {
        public MessageElement(string name, string text, DateTime dateTime)
        {
            InitializeComponent();
            userName.Content = name;
            messageText.Text = text;
            messageDate.Content = dateTime.ToLongTimeString();
        }
    }
}
