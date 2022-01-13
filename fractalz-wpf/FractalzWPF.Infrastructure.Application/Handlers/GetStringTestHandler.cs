using FractalzWPF.Infrastructure.Application.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzWPF.Infrastructure.Application.Handlers
{
    public class GetStringTestHandler
    {
        private readonly IConnector _connector;
        public GetStringTestHandler(IConnector connector)
        {
            _connector = connector;
        }

        public string Handle()
        {
            return  string.Empty;
        }
    }
}
