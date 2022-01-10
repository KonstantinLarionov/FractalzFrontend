using FractalzWPF.Infrastructure.Application.Domains.Enums;
using FractalzWPF.Infrastructure.Application.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FractalzWPF.Infrastructure.Application.Application
{
    public interface INavigatorControls
    {
        public Dictionary<UserControlType, UserControl> Controls { get; }
        public Dictionary<WindowType, Window> Windows { get; }
    }
}
