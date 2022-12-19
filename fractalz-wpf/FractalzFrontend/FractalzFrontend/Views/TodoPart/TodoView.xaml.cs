﻿using FractalzFrontend.ViewModels.TodoPart;

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

namespace FractalzFrontend.Views.TodoPart
{
    /// <summary>
    /// Логика взаимодействия для TodoView.xaml
    /// </summary>
    public partial class TodoView : UserControl
    {
        private TodoVM _vm = new TodoVM();
        public TodoView()
        {
            InitializeComponent();
            DataContext = _vm;

        }
    }
}
