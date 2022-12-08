using FractalzFrontend.Application.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Application.Abstractions
{
    public interface ILogDispatcher
    {
        void SetFileName(LoggerNameFile name);
        string GetFileName();
        void Success(string header, string message);
        void Success(string header, object message);
        void Info(string header, string message);
        void Info(string header, object message);
        void Error(string header, string message);
        void Error(string header, object message);
    }
}
