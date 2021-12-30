using FractalzWPF.Infrastructure.Application.Application;
using System;

namespace FractalzWPF.Infrastructure.Connector
{
    public class Connector : IConnector
    {
        public string Test()
        {
            return "Hello World!";
        }
    }
}
