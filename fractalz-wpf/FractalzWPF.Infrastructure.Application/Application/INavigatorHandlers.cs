using FractalzWPF.Infrastructure.Application.Handlers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractalzWPF.Infrastructure.Application.Handlers.User;

namespace FractalzWPF.Infrastructure.Application.Application
{
    public interface INavigatorHandlers
    {
        public RegistrationHandler RegistrationHandler { get; set; }
    }
}
