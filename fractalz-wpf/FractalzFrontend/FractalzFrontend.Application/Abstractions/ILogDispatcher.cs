using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Application.Abstractions
{
    public interface ILogDispatcher
    {
        void SetFileName(string name);
        string GetFileName(string name);
        void Success(string header, string message);
        void Success(string header, object message);
        void Info(string header, string message);
        void Info(string header, object message);
        void Error(string header, string message);
        void Error(string header, object message);
    }
}
