using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Application.Abstractions
{
    public interface IRestClient
    {
        T Send<T>(object request, string resource, Method method, out ErrorResponse error);
        T SendForm<T>(object request, string resource, Method method, out ErrorResponse error);
    }
}
