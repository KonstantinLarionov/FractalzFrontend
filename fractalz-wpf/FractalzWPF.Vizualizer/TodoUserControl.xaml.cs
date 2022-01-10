﻿using FractalzWPF.Infrastructure.Vizualizer.Elements;
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
    /// Логика взаимодействия для TodoUserControl.xaml
    /// </summary>
    public partial class TodoUserControl : UserControl
    {
        public TodoUserControl()
        {
            InitializeComponent();
            todoList.Children.Add(new TodoElement());
            todoList.Children.Add(new TodoElement());
            todoList.Children.Add(new TodoElement());
            todoList.Children.Add(new TodoElement());
            todoList.Children.Add(new TodoElement());
            todoList.Children.Add(new TodoElement());
            todoList.Children.Add(new TodoElement());
            todoList.Children.Add(new TodoElement());
            todoList.Children.Add(new TodoElement());
        }
    }
}
