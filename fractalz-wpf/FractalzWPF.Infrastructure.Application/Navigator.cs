using FractalzWPF.Infrastructure.Application.Application;
using FractalzWPF.Infrastructure.Application.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Infrastructure.Application
{
    public class Navigator : INavigatorHandlers
    {
        public GetStringTestHandler _testHandler { get; set; }
        public Navigator(GetStringTestHandler testHandler)
        {
            _testHandler = testHandler;
        }
    }
}
