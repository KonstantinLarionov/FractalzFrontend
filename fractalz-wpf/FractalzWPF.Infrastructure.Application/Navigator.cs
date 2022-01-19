using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Infrastructure.Application.Handlers.User;

namespace FractalzWPF.Infrastructure.Application
{
    public class Navigator : INavigatorHandlers
    {
        public RegistrationHandler RegistrationHandler { get; set; }
        public Navigator(RegistrationHandler regHandler)
        {
            RegistrationHandler = regHandler;
        }
    }
}
