using FractalzWPF.Infrastructure.Application.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Infrastructure.Application.Application
{
    public interface INavigator
    {
        public GetStringTestHandler _testHandler { get; set; }
    }
}
